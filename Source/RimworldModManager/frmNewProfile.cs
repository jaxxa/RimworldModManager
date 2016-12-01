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
    public partial class frmNewProfile : Form
    {
        public frmNewProfile()
        {
            InitializeComponent();
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void bttnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public static RimworldModManager.ProgramSettings.Profile GetNewProfile()
        {
            frmNewProfile _frmNewProfile = new frmNewProfile();
            DialogResult _result = _frmNewProfile.ShowDialog();

            if (_result == DialogResult.OK)
            {
                RimworldModManager.ProgramSettings.Profile _NewProfile = new ProgramSettings.Profile();

                _NewProfile.RimworldFolder = _frmNewProfile.txbxRimworldFolder.Text;
                _NewProfile.ConfigFolder = _frmNewProfile.txbxConfigFolder.Text;
                _NewProfile.WorkshopFolder = _frmNewProfile.txbxWorkshopFolder.Text;

                return _NewProfile;
            }
            return null;
        }

        private void bttnChooseRimworldFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog _ChooseDialog = new FolderBrowserDialog();
            _ChooseDialog.SelectedPath = this.txbxRimworldFolder.Text;
            _ChooseDialog.Description = "Please select the folder that contains Rimworld.exe";
            DialogResult _Result = _ChooseDialog.ShowDialog();

            if (_Result == DialogResult.OK)
            {
                this.txbxRimworldFolder.Text = _ChooseDialog.SelectedPath;
            }
        }

        private void bttnChooseSaveFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog _ChooseDialog = new FolderBrowserDialog();
            _ChooseDialog.SelectedPath = this.txbxConfigFolder.Text;
            _ChooseDialog.Description = "Please select the Config Folder that contains the 'Saves' folder. If you are not overriding it the default should already be selected. If you are overriding it this will be the folder that   you pass in as a paramiter to Rimworld. Note that this will need to be a full path or relitive to this program.";
            DialogResult _Result = _ChooseDialog.ShowDialog();

            if (_Result == DialogResult.OK)
            {
                this.txbxConfigFolder.Text = _ChooseDialog.SelectedPath;
            }
        }

        private void bttnChooseWorkshopFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog _ChooseDialog = new FolderBrowserDialog();
            _ChooseDialog.SelectedPath = this.txbxWorkshopFolder.Text;
            _ChooseDialog.Description = "Please select the folder that contains the Workshop Mods";
            DialogResult _Result = _ChooseDialog.ShowDialog();

            if (_Result == DialogResult.OK)
            {
                this.txbxWorkshopFolder.Text = _ChooseDialog.SelectedPath;
            }
        }

        private void frmNewProfile_Load(object sender, EventArgs e)
        {
            this.txbxConfigFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
                                                                 @"Low\Ludeon Studios\RimWorld";
        }

    }
}