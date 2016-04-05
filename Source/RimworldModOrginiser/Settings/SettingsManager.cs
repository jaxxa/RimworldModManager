using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RimworldModOrginiser.ProgramSettings
{
    public class SettingsManager
    {
        public List<Profile> Profiles = new List<Profile>();
        public Profile ActiveProfile;

        public string RimworldFolder
        {
            get
            {
                return this.ActiveProfile.RimworldFolder;
            }
        }

        public string SaveFolder
        {
            get
            {
                return this.ActiveProfile.SaveFolder;
            }
        }
        string m_SaveFolder;

        public void Load()
        {

            if (System.IO.File.Exists(@"Settings.xml"))
            {
                XmlDocument _XmlSettingsDocument = new XmlDocument();
                _XmlSettingsDocument.Load(@"Settings.xml");

                XmlNode _XmlRmoProfiles = _XmlSettingsDocument.SelectSingleNode(@"RimworldModOrginiser/RMOProfiles");
                
                foreach (XmlNode _XmlProfile in _XmlRmoProfiles.ChildNodes)
                {
                    Profile _NewProfile = new Profile();

                    var _XmlRimworldFolder = _XmlProfile.SelectSingleNode(@"RimworldFolder");
                    _NewProfile.RimworldFolder = _XmlRimworldFolder.InnerText;

                    var _XmlSaveFolder = _XmlProfile.SelectSingleNode(@"SaveFolder");
                    _NewProfile.SaveFolder = _XmlSaveFolder.InnerText;

                    this.Profiles.Add(_NewProfile);

                }

               
            }
        }

        public void Save()
        {

        }
    }
}
