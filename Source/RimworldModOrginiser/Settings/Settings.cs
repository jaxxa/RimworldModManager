using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RimworldModOrginiser.DataObjects
{
    class Settings
    {
        public string RimworldFolder
        {
            get
            {
                return this.m_RimworldFolder;
            }
            set
            {
                this.m_RimworldFolder = value;
            }
        }
        string m_RimworldFolder;

        public string SaveFolder
        {
            get
            {
                return this.m_SaveFolder;
            }
            set
            {
                this.m_SaveFolder = value;
            }
        }
        string m_SaveFolder;

        public void Load()
        {

            if (System.IO.File.Exists(@"Config.xml"))
            {
                XmlDocument _ConfigFile = new XmlDocument();
                _ConfigFile.Load(@"Config.xml");

                var _XmlRimworldFolder = _ConfigFile.DocumentElement.SelectSingleNode(@"/RimworldModOrginiser/Config/RimworldFolder");
                this.RimworldFolder = _XmlRimworldFolder.InnerText;

                var _XmlSaveFolder = _ConfigFile.DocumentElement.SelectSingleNode(@"/RimworldModOrginiser/Config/SaveFolder");
                this.SaveFolder = _XmlSaveFolder.InnerText;
                
            }
        }
    }
}
