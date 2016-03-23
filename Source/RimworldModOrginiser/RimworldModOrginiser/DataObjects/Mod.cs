using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RimworldModOrginiser.DataObjects
{
    class Mod
    {
        string m_Name;
        string m_Author;
        string m_Url;
        string m_Description;

        //Convert this to its own class eventually.
        List<String> m_Dependencies = new List<string>();

        public void load(string modFolder)
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
