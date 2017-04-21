using RimworldModManager.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RimworldModManager
{
    public partial class frmResearch : Form
    {

        ModManager m_Manager;


        public frmResearch()
        {
            InitializeComponent();
        }

        private void bttnLoad_Click(object sender, EventArgs e)
        {

            foreach (ModDetails _CurrentMod in this.m_Manager.ModList)
            {
                if (_CurrentMod.IsActive)
                {
                    //Find all .xml files
                    List<string> _xmlFiles = this.GetAllXmlFiles(_CurrentMod.ModFilePath);

                    //Iterate finding Research
                    List<string> xmlResearchFiles = _xmlFiles.Where(x => this.FileContainsText(x, "ResearchProjectDef")).ToList();

                    //Load Research Objects
                    xmlResearchFiles.ForEach(d => this.XmlPathToResearchObjects(d));
                }
            }

            //Dislpay Research Objects
        }

        public void XmlPathToResearchObjects(String xmlFile)
        {
            Console.WriteLine(xmlFile);

            if (System.IO.File.Exists(xmlFile))
            {
                XmlDocument _XmlSettingsDocument = new XmlDocument();
                _XmlSettingsDocument.Load(xmlFile);

                // XmlNode _XmlRmoProfiles = _XmlSettingsDocument.SelectSingleNode(@"RimworldModManager/RMOProfiles");

                //Iterate Through Top Level Nodes
                foreach (XmlNode _XmlNode in _XmlSettingsDocument)
                {
                    //If the node does not contain a ResearchProjectDef goto the next one.
                    if (!_XmlNode.InnerXml.Contains("ResearchProjectDef")) { continue; };

                    XmlNodeList _ResearchProjectNodes = _XmlNode.SelectNodes(@"ResearchProjectDef");

                    foreach (XmlNode _ResearchNode in _ResearchProjectNodes)
                    {
                        //Dont import Abstracts.
                        var _Abstract = _ResearchNode.Attributes.GetNamedItem("Abstract");
                        if (_Abstract != null && _Abstract.Value == "True") { continue; };

                        XmlNode _XmlDefName = _ResearchNode.SelectSingleNode(@"defName");
                        String _DefName = _XmlDefName.InnerText;

                        XmlNode _XmlResearchViewX = _ResearchNode.SelectSingleNode(@"researchViewX");
                        String _ResearchViewX = _XmlResearchViewX.InnerText;

                        XmlNode _XmlResearchViewY = _ResearchNode.SelectSingleNode(@"researchViewY");
                        String _ResearchViewY = _XmlResearchViewY.InnerText;

                    }

                    //Profile _NewProfile = new Profile();


                    //var _XmlConfigFolder = _XmlProfile.SelectSingleNode(@"ConfigFolder");
                    //_NewProfile.ConfigFolder = _XmlConfigFolder.InnerText;

                    //var _XmlWorkshopFolder = _XmlProfile.SelectSingleNode(@"WorkshopFolder");
                    //if (_XmlWorkshopFolder != null)
                    //{
                    //    _NewProfile.WorkshopFolder = _XmlWorkshopFolder.InnerText;
                    //}

                    //this.Profiles.Add(_NewProfile);

                }
            }

        }

        //Create Patch Mod

        public static void ManageResearch(ModManager manager)
        {
            frmResearch _frmResearch = new frmResearch();
            _frmResearch.m_Manager = manager;

            DialogResult _result = _frmResearch.ShowDialog();

            if (_result == DialogResult.OK)
            {

                //   _NewProfile.RimworldFolder = _frmNewProfile.txbxRimworldFolder.Text;

                // return _NewProfile;
            }
            return;
        }

        private List<string> GetAllXmlFiles(string modPath)
        {
            List<string> _XmlFiles = new List<string>();

            //Search for Files
            string[] _Files = System.IO.Directory.GetFiles(modPath);
            foreach (string _File in _Files)
            {
                if (String.Equals(".xml", System.IO.Path.GetExtension(_File)))
                {
                    _XmlFiles.Add(_File);
                }
            }

            //Search SubFolders
            string[] _Folders = System.IO.Directory.GetDirectories(modPath);
            foreach (string _Folder in _Folders)
            {
                _XmlFiles.AddRange(this.GetAllXmlFiles(_Folder));
            }

            //Return
            return _XmlFiles;
        }

        private bool FileContainsText(string filePath, string searchText)
        {
            String _fileText = System.IO.File.ReadAllText(filePath);
            if (String.IsNullOrWhiteSpace(_fileText)) { return false; }
            return _fileText.Contains(searchText);

        }
    }
}
