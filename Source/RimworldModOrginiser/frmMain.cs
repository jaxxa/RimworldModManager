using RimworldModOrginiser.DataObjects;
using RimworldModOrginiser.ProgramSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RimworldModOrginiser
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        #region Fields

        ModManager m_Manager;

        SettingsManager m_SettingsManager;

        private List<DataObjects.ModDetails> m_SelctedMods = new List<DataObjects.ModDetails>();

        #endregion Fields

        #region Gui Events

        private void bttnLoad_Click(object sender, EventArgs e)
        {
            //this.m_SettingsManager = new SettingsManager();
            //this.m_SettingsManager.Load();

            this.m_SettingsManager = frmSettings.GetSettings();
            if (this.m_SettingsManager == null) { return; }


            this.m_Manager = new RimworldModOrginiser.DataObjects.ModManager();

            this.m_Manager.LoadModList(this.m_SettingsManager.RimworldFolder);

            this.m_Manager.LoadModConfig(this.m_SettingsManager.ConfigFolder);

            this.m_Manager.CheckIssues();

            this.UpdateOrder();

            if (this.m_SettingsManager.ActiveProfile == null)
            {
                lblProfile.Text = "No Profile Loaded";
            }
            else
            {
                lblProfile.Text = this.m_SettingsManager.ActiveProfile.ToString();
            }

        }

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
            this.m_Manager.SaveConfig(this.m_SettingsManager.ConfigFolder);
        }

        private void bttnSaveAndRun_Click(object sender, EventArgs e)
        {

            this.m_Manager.SaveConfig(this.m_SettingsManager.ConfigFolder);

            string _FilePath = this.FindExecutable(this.m_SettingsManager.RimworldFolder);

            if (_FilePath != null)
            {

                System.Diagnostics.Process.Start(_FilePath,
                   "\" -savedatafolder=" + this.m_SettingsManager.ConfigFolder + "\"");
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
    }
}