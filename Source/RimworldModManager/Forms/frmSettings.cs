﻿using System;
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
    public partial class frmSettings : Form
    {
        private RimworldModManager.ProgramSettings.ProfileManager m_SettingManager;

        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

            this.m_SettingManager = new ProgramSettings.ProfileManager();

            this.m_SettingManager.Load();

            this.bsrcSettings.DataSource = this.m_SettingManager.Profiles;
        }

        private void bttnOk_Click(object sender, EventArgs e)
        {
            this.m_SettingManager.Save();
            this.m_SettingManager.ActiveProfile = (ProgramSettings.Profile)this.bsrcSettings.Current;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bttnNew_Click(object sender, EventArgs e)
        {
            ProgramSettings.Profile _NewProfile = frmNewProfile.GetNewProfile();

            if (_NewProfile != null)
            {
                this.m_SettingManager.Profiles.Add(_NewProfile);
            }


            this.bsrcSettings.DataSource = null;
            this.bsrcSettings.DataSource = this.m_SettingManager.Profiles;
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

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dgrvSettings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public static ProgramSettings.ProfileManager GetSettings()
        {
            var _frmSettings = new frmSettings();

            DialogResult _Result = _frmSettings.ShowDialog();

            if (_Result != DialogResult.OK)
            {
                return null;
            }

            return _frmSettings.m_SettingManager;
        }
    }
}
