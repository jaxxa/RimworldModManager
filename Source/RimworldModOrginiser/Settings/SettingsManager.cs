using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

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
                if (this.ActiveProfile == null)
                {
                    return null;
                }
                return this.ActiveProfile.RimworldFolder;
            }
        }

        public string SaveFolder
        {
            get
            {

                if (this.ActiveProfile == null)
                {
                    return null;
                }

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


            XDocument _XmlSettings = new XDocument();

            XElement _XmlRimworldModOrginiser = new XElement("RimworldModOrginiser");
            XElement _XmlRMOProfiles = new XElement("RMOProfiles");

            foreach (Profile _CurrentProfile in this.Profiles)
            {
                XElement _XmlProfile = new XElement("Profile");
                _XmlProfile.Add(new XElement("RimworldFolder", _CurrentProfile.RimworldFolder));
                _XmlProfile.Add(new XElement("SaveFolder", _CurrentProfile.SaveFolder));

                _XmlRMOProfiles.Add(_XmlProfile);
            }

            _XmlRimworldModOrginiser.Add(_XmlRMOProfiles);
            _XmlSettings.Add(_XmlRimworldModOrginiser);

            _XmlSettings.Save(@"Settings.xml");

        }
    }
}
