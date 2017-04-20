﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace RimworldModManager.ProgramSettings
{
    public class ProfileManager
    {

        public List<Profile> Profiles = new List<Profile>();
        public Profile ActiveProfile;

        public string ActiveProfile_RimworldFolder
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

        public string ActiveProfile_ConfigFolder
        {
            get
            {
                if (this.ActiveProfile == null)
                {
                    return null;
                }
                return this.ActiveProfile.ConfigFolder;
            }
        }

        public string ActiveProfile_WorkshopFolder
        {
            get
            {
                if (this.ActiveProfile == null)
                {
                    return null;
                }
                return this.ActiveProfile.WorkshopFolder;
            }
        }

        public void Load()
        {

            if (System.IO.File.Exists(@"Settings.xml"))
            {
                XmlDocument _XmlSettingsDocument = new XmlDocument();
                _XmlSettingsDocument.Load(@"Settings.xml");

                XmlNode _XmlRmoProfiles = _XmlSettingsDocument.SelectSingleNode(@"RimworldModManager/RMOProfiles");

                foreach (XmlNode _XmlProfile in _XmlRmoProfiles.ChildNodes)
                {
                    Profile _NewProfile = new Profile();

                    var _XmlRimworldFolder = _XmlProfile.SelectSingleNode(@"RimworldFolder");
                    _NewProfile.RimworldFolder = _XmlRimworldFolder.InnerText;

                    var _XmlConfigFolder = _XmlProfile.SelectSingleNode(@"ConfigFolder");
                    _NewProfile.ConfigFolder = _XmlConfigFolder.InnerText;

                    var _XmlWorkshopFolder = _XmlProfile.SelectSingleNode(@"WorkshopFolder");
                    if(_XmlWorkshopFolder != null)
                    {
                        _NewProfile.WorkshopFolder = _XmlWorkshopFolder.InnerText;
                    }

                    this.Profiles.Add(_NewProfile);

                }
            }
        }

        public void Save()
        {


            XDocument _XmlSettings = new XDocument();

            XElement _XmlRimworldModManager = new XElement("RimworldModManager");
            XElement _XmlRMOProfiles = new XElement("RMOProfiles");

            foreach (Profile _CurrentProfile in this.Profiles)
            {
                XElement _XmlProfile = new XElement("Profile");
                _XmlProfile.Add(new XElement("RimworldFolder", _CurrentProfile.RimworldFolder));
                _XmlProfile.Add(new XElement("ConfigFolder", _CurrentProfile.ConfigFolder));
                _XmlProfile.Add(new XElement("WorkshopFolder", _CurrentProfile.WorkshopFolder));

                _XmlRMOProfiles.Add(_XmlProfile);
            }

            _XmlRimworldModManager.Add(_XmlRMOProfiles);
            _XmlSettings.Add(_XmlRimworldModManager);

            _XmlSettings.Save(@"Settings.xml");

        }

    }
}
