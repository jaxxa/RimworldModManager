using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RimworldModOrginiser.DataObjects
{
    class ModDetails
    {
        
        #region Properties

        //Data storage properties--------------------------

        public string Name
        {
            get
            {
                return this.m_Name;
            }
            set
            {
                this.m_Name = value;
            }
        }
        string m_Name;

        public string Author
        {
            get
            {
                return this.m_Author;
            }
            set
            {
                this.m_Author = value;
            }
        }
        string m_Author;

        public string Url
        {
            get
            {
                return this.m_Url;
            }
            set
            {
                this.m_Url = value;
            }
        }
        string m_Url;

        public string Description
        {
            get
            {
                return this.m_Description;
            }
            set
            {
                this.m_Description = value;
            }
        }
        string m_Description;
        
        //Convert this to its own class eventually instead of strings?
        public List<String> Dependencies
        {
            get
            {
                return this.m_Dependencies;
            }
            set
            {
                this.m_Dependencies = value;
            }
        }
        List<String> m_Dependencies = new List<string>();

        public int Sequence
        {
            get
            {
                return this.m_Sequence;
            }
            set
            {
                this.m_Sequence = value;
            }
        }
        private int m_Sequence = ModManager.INACTIVE_SEQUENCE;
        
        public bool ExistsInConfig
        {
            get
            {
                return this.m_ExistsInConfig;
            }
            set
            {
                this.m_ExistsInConfig = value;
            }
        }
        private bool m_ExistsInConfig = false;

        public bool ExistsInDisk
        {
            get
            {
                return this.m_ExistsInDisk;
            }
            set
            {
                this.m_ExistsInDisk = value;
            }
        }
        private bool m_ExistsInDisk = false;
        
        public bool ExistsInDependencies
        {
            get
            {
                return this.m_ExistsInDependencies;
            }
            set
            {
                this.m_ExistsInDependencies = value;
            }
        }
        private bool m_ExistsInDependencies = false;
        
        public bool ExistsInAbout
        {
            get
            {
                return this.m_ExistsInAbout;
            }
            set
            {
                this.m_ExistsInAbout = value;
            }
        }
        private bool m_ExistsInAbout = false;

        //Helper Properties---------------------------------------------------------
        
        public string SequenceDescription
        {
            get
            {
                if (int.Equals(this.Sequence, ModManager.INACTIVE_SEQUENCE))
                {
                    return "Inactive";
                }
                else
                {
                    return this.Sequence.ToString();
                }
            }
        }

        public bool IsCore
        {
            get
            {
                return string.Equals(this.Name, "Core");
            }
        }

        public bool IsActive
        {
            get
            {
                return this.Sequence != ModManager.INACTIVE_SEQUENCE;
            }
        }
        
        public string Details
        {
            get
            {
                StringBuilder _Details = new StringBuilder();

                _Details.AppendLine("Name:" + this.Name);
                _Details.AppendLine("Sequence:" + this.Sequence.ToString());
                _Details.AppendLine("Author:" + this.Author);
                _Details.AppendLine("Description:" + this.Description);
                _Details.AppendLine("URL:" + this.Url);
                _Details.AppendLine("");
                _Details.AppendLine("Dependencies:");

                foreach (string _Dependencie in this.Dependencies)
                {
                    _Details.AppendLine(_Dependencie);
                }

                if (this.Issues != null)
                {
                    _Details.AppendLine("");
                    _Details.AppendLine("Issues:");
                    _Details.AppendLine(this.Issues);
                }

                return _Details.ToString();
            }
        }

        //Convert this to its own class list of string instead of string?
        public string Issues
        {
            get
            {
                return this.m_Issues;
            }
            set
            {
                this.m_Issues = value;
            }
        }
        private string m_Issues;

        #endregion ' Properties

        #region Methods
        
        public void load(string modFolder)
        {
            if (System.IO.File.Exists(modFolder + @"\About\About.xml"))
            {
                XmlDocument _AboutFile = new XmlDocument();
                _AboutFile.Load(modFolder + @"\About\About.xml");

                var _XmlName = _AboutFile.DocumentElement.SelectSingleNode("/ModMetaData/name");
                this.m_Name = _XmlName.InnerText;

                var _XmlAuthor = _AboutFile.DocumentElement.SelectSingleNode("/ModMetaData/author");
                this.m_Author = _XmlAuthor.InnerText;

                var _XmlUrl = _AboutFile.DocumentElement.SelectSingleNode("/ModMetaData/url");
                this.m_Url = _XmlUrl.InnerText;

                var _XmlDescription = _AboutFile.DocumentElement.SelectSingleNode("/ModMetaData/description");
                this.m_Description = _XmlDescription.InnerText;

                this.m_ExistsInAbout = true;
            }


            if (System.IO.File.Exists(modFolder + @"\About\Dependencies.xml"))
            {

                XmlDocument _XmlDependenciesFile = new XmlDocument();
                _XmlDependenciesFile.Load(modFolder + @"\About\Dependencies.xml");

                var _XmlDependencies = _XmlDependenciesFile.DocumentElement.SelectSingleNode("/ModDependencieMetaData/Dependencies");

                foreach (XmlNode _CurrentNode in _XmlDependencies.ChildNodes)
                {
                    this.m_Dependencies.Add(_CurrentNode.InnerText);
                }
                this.ExistsInDependencies = true;
            }

            this.m_ExistsInDisk = true;
        }

        public void configValues(int sequence)
        {
            this.Sequence = sequence;
            this.ExistsInConfig = true;
        }

        public override string ToString()
        {
            return "ModDetails: " + this.Sequence + " : " + this.Name;
            //return base.ToString();
        }
        
        public void CheckIssues(ModManager parentManager)
        {
            StringBuilder _Problems = new StringBuilder();

            if (this.IsCore && this.Sequence != 0)
            {
                _Problems.AppendLine("Core must be active and the first in the sequence");
            }

            if(!this.ExistsInDisk)
            {
                _Problems.AppendLine("Missing on Disk");
            }
            else
            {
                if (!this.ExistsInAbout)
                {
                    _Problems.AppendLine("Missing About.xml");
                }
                if (!this.ExistsInDependencies && !this.IsCore)
                {
                    _Problems.AppendLine("Not Checked - No Dependencies.xml");
                }
            }


            foreach (string _CurrentDependencyName in this.Dependencies)
            {
                ModDetails _CurrentDependency = parentManager.GetModByName(_CurrentDependencyName);

                if (_CurrentDependency == null)
                {
                    _Problems.AppendLine("Missing Dependencie: " + _CurrentDependencyName);
                }
                else if (!_CurrentDependency.IsActive) 
                {
                    _Problems.AppendLine("Inactive Dependencie: " + _CurrentDependencyName);
                }
                else if(_CurrentDependency.Sequence > this.Sequence)
                {
                    _Problems.AppendLine("Dependencie later in load order: " + _CurrentDependencyName);
                }
            }
            
            if (_Problems.Length == 0)
            {
              //  _Problems.AppendLine("No issues found");
            }

            this.Issues = _Problems.ToString();
        }
        
        #endregion

    }
}
