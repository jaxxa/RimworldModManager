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

        #endregion ' Properties
        
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
            }
        }

    }
}
