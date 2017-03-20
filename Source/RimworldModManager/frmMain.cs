using RimworldModManager.DataObjects;
using RimworldModManager.ProgramSettings;
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
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        #region Fields

        ModManager m_Manager;

        ProfileManager m_ProfileManager;

        private List<DataObjects.ModDetails> m_SelctedMods = new List<DataObjects.ModDetails>();

        #endregion Fields

        #region Gui Events
        /*
        private void bttnLoad_Click(object sender, EventArgs e)
        {
            //this.m_SettingsManager = new SettingsManager();
            //this.m_SettingsManager.Load();

            this.m_ProfileManager = frmSettings.GetSettings();
            if (this.m_ProfileManager == null) { return; }


            this.m_Manager = new RimworldModManager.DataObjects.ModManager();

            this.m_Manager.LoadModList(this.m_ProfileManager.ActiveProfile_RimworldFolder, this.m_ProfileManager.ActiveProfile_WorkshopFolder);

            this.m_Manager.LoadModConfig(this.m_ProfileManager.ActiveProfile_ConfigFolder);

            this.m_Manager.CheckIssues();

            this.UpdateOrder();

            if (this.m_ProfileManager.ActiveProfile == null)
            {
                lblProfile.Text = "No Profile Loaded";
            }
            else
            {
                lblProfile.Text = this.m_ProfileManager.ActiveProfile.ToString();
            }

        }
        */
        private void toolModGrid_MoveUp_Click(object sender, EventArgs e)
        {
            this.SaveSelection();

            List<ModDetails> temp = new List<ModDetails>();

            foreach (DataGridViewRow _CurrentRow in dgrvMods.SelectedRows)
            {
                DataObjects.ModDetails _CurrentMod = (DataObjects.ModDetails)_CurrentRow.DataBoundItem;
                temp.Add(_CurrentMod);
            }

            temp.Reverse();


            foreach (ModDetails _CurrentMod in temp)
            {
                this.m_Manager.MoveModUp(_CurrentMod);
            }


            //Update grid sequence
            this.UpdateOrder();
            //Reselect

            this.m_Manager.CheckIssues();

            this.LoadSelection();
        }

        private void toolModGrid_MoveDown_Click(object sender, EventArgs e)
        {
            this.SaveSelection();

            foreach (DataGridViewRow _CurrentRow in dgrvMods.SelectedRows)
            {
                DataObjects.ModDetails _CurrentMod = (DataObjects.ModDetails)_CurrentRow.DataBoundItem;
                this.m_Manager.MoveModDown(_CurrentMod);
            }

            //this.m_Manager.ModList = this.m_Manager.ModList.OrderBy(o => o.Sequence);

            //var temp = this.m_Manager.ModList.OrderBy(o => o.Sequence);

            //this.bsrcModDetails.DataSource = null;
            //this.bsrcModDetails.DataSource = this.m_Manager.ModList;

            //Update grid sequence
            this.UpdateOrder();

            // dgrvMods.Sort(dgrvMods_Sequence, ListSortDirection.Descending);
            //Reselect


            this.m_Manager.CheckIssues();

            this.LoadSelection();
        }

        private void toolModGrid_Toggle_Click(object sender, EventArgs e)
        {
            this.SaveSelection();
            //this.FullSelect();

            foreach (DataGridViewRow _CurrentRow in dgrvMods.SelectedRows)
            {
                DataObjects.ModDetails _CurrentMod = (DataObjects.ModDetails)_CurrentRow.DataBoundItem;
                this.m_Manager.Toggle(_CurrentMod);
            }
            this.UpdateOrder();

            this.m_Manager.CheckIssues();

            this.LoadSelection();
        }

        private void dgrvMods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            this.toolModGrid_Toggle_Click(sender, e);
        }

        private void dgrvMods_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewCell _CurrentCell in dgrvMods.SelectedCells)
            {
                ModDetails _CurrentMod = (DataObjects.ModDetails)_CurrentCell.OwningRow.DataBoundItem;

                this.txbxModDetails.Text = _CurrentMod.Details;

                return;

            }

            this.txbxModDetails.Text = null;
        }

        #endregion

        #region Methods

        private void SaveSelection()
        {
            this.FullSelect();

            this.m_SelctedMods.Clear();

            foreach (DataGridViewRow _CurrentRow in dgrvMods.SelectedRows)
            {
                ModDetails _CurrentMod = (DataObjects.ModDetails)_CurrentRow.DataBoundItem;

                this.m_SelctedMods.Add(_CurrentMod);
            }
        }

        private void LoadSelection()
        {
            dgrvMods.ClearSelection();

            foreach (DataGridViewRow _CurrentRow in dgrvMods.Rows)
            {
                if (this.m_SelctedMods.Contains((DataObjects.ModDetails)_CurrentRow.DataBoundItem))
                {
                    _CurrentRow.Selected = true;
                }
            }
        }

        private void UpdateOrder()
        {

            this.m_Manager.Reorder();
            dgrvMods.DataSource = null;
            dgrvMods.DataSource = m_Manager.ModList;
            dgrvMods.Refresh();
        }

        /// <summary>
        /// Select all rows that have atleast one cell selected.
        /// </summary>
        private void FullSelect()
        {
            foreach (DataGridViewCell _CurrentCell in dgrvMods.SelectedCells)
            {
                _CurrentCell.OwningRow.Selected = true;

            }
        }

        #endregion

        private void bttnSaveConfig_Click(object sender, EventArgs e)
        {
            this.m_Manager.SaveConfig(this.m_ProfileManager.ActiveProfile_ConfigFolder);
        }

        private void bttnSaveAndRun_Click(object sender, EventArgs e)
        {

            this.m_Manager.SaveConfig(this.m_ProfileManager.ActiveProfile_ConfigFolder);

            string _FilePath = this.FindExecutable(this.m_ProfileManager.ActiveProfile_RimworldFolder);

            if (_FilePath != null)
            {
                string _Paramiter = " -savedatafolder=\"" + this.m_ProfileManager.ActiveProfile_ConfigFolder + "\"";
                System.Diagnostics.Process.Start(_FilePath, _Paramiter);
            }
        }

        private string FindExecutable(String folderPath)
        {
            if (!System.IO.Directory.Exists(folderPath))
            {
                return null;
            }

            string[] files = System.IO.Directory.GetFiles(folderPath);

            foreach (string _FileFullPath in files)
            {
                string _Extention = System.IO.Path.GetExtension(_FileFullPath);
                if (_Extention == ".exe")
                {
                    string _FileName = System.IO.Path.GetFileNameWithoutExtension(_FileFullPath);
                    if (_FileName.Contains("RimWorld"))
                    {
                        return _FileFullPath;
                    }
                }
            }

            return null;
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            this.m_ProfileManager = new ProgramSettings.ProfileManager();

            this.m_ProfileManager.Load();

            this.bsrcSettings.DataSource = this.m_ProfileManager.Profiles;
        }

        private void bttnNew_Click(object sender, EventArgs e)
        {
            ProgramSettings.Profile _NewProfile = frmNewProfile.GetNewProfile();

            if (_NewProfile != null)
            {
                this.m_ProfileManager.Profiles.Add(_NewProfile);
            }


            this.bsrcSettings.DataSource = null;
            this.bsrcSettings.DataSource = this.m_ProfileManager.Profiles;
            this.dgrvSettings.Refresh();

            dgrvSettings.ClearSelection();

            foreach (DataGridViewRow _CurrentRow in dgrvSettings.Rows)
            {
                ProgramSettings.Profile _CurrentRowItem = (ProgramSettings.Profile)_CurrentRow.DataBoundItem;

                if (_NewProfile == _CurrentRowItem)
                {
                    _CurrentRow.Selected = true;
                    dgrvSettings.CurrentCell = dgrvSettings.Rows[_CurrentRow.Cells[0].RowIndex].Cells[0];
                }
                else
                {
                    _CurrentRow.Selected = false;
                }
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            // this.m_SettingManager.Profiles.Remove((ProgramSettings.Profile)this.bsrcSettings.Current);
            this.bsrcSettings.Remove((ProgramSettings.Profile)this.bsrcSettings.Current);
            this.dgrvSettings.Refresh();
        }

        private void bttnLoadProfile_Click(object sender, EventArgs e)
        {
            this.m_ProfileManager.ActiveProfile = (ProgramSettings.Profile)this.bsrcSettings.Current;

            this.m_Manager = new RimworldModManager.DataObjects.ModManager();

            this.m_Manager.LoadModList(this.m_ProfileManager.ActiveProfile_RimworldFolder, this.m_ProfileManager.ActiveProfile_WorkshopFolder);

            this.m_Manager.LoadModConfig(this.m_ProfileManager.ActiveProfile_ConfigFolder);

            this.m_Manager.CheckIssues();

            this.UpdateOrder();

            if (this.m_ProfileManager.ActiveProfile == null)
            {
                lblProfile.Text = "No Profile Loaded";
            }
            else
            {
                lblProfile.Text = this.m_ProfileManager.ActiveProfile.ToString();
            }


        }

        private void bttnSaveProfile_Click(object sender, EventArgs e)
        {
            this.m_ProfileManager.Save();
        }



        #region Research

      //  Research.ResearchManager m_ResearchManager;

        private void bttnLoadResearch_Click(object sender, EventArgs e)
        {
            //

            foreach (ModDetails _CurrentMod in this.m_Manager.ModList)
            {
                if (_CurrentMod.IsActive)
                {
                    //Find all .xml files
                    List<string> _xmlFiles = this.GetAllXmlFiles(_CurrentMod.ModFilePath);

                    //Iterate finding Research
                    //List<string> xmlResearchFiles = _xmlFiles.Where(x => x.Contains("Research")).ToList();
                    List<string> xmlResearchFiles = _xmlFiles.Where(x => this.FileContainsText(x, "ResearchProjectDef") ).ToList();

                    //Load Research Objects


                }
            }

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


            return false;
        }

        //private List<string> FilterResearchFiles(List<string> xmlFiles)
        //{

        //}

        #endregion

    }
}