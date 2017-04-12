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
                    //List<string> xmlResearchFiles = _xmlFiles.Where(x => x.Contains("Research")).ToList();
                    List<string> xmlResearchFiles = _xmlFiles.Where(x => this.FileContainsText(x, "ResearchProjectDef")).ToList();

                    //Load Research Objects


                }
            }
        }

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
