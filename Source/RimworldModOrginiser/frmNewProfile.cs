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

        public static RimworldModOrginiser.ProgramSettings.Profile GetNewProfile()
        {
            frmNewProfile _frmNewProfile = new frmNewProfile();
            DialogResult _result = _frmNewProfile.ShowDialog();

            if (_result == DialogResult.OK)
            {
                RimworldModOrginiser.ProgramSettings.Profile _NewProfile = new ProgramSettings.Profile();

                _NewProfile.RimworldFolder = _frmNewProfile.txbxRimworldFolder.Text;
                _NewProfile.SaveFolder = _frmNewProfile.txbxSaveFolder.Text;

                return _NewProfile;
            }
            return null;
        }

        private void bttnChooseRimworldFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog _ChooseDialog = new FolderBrowserDialog();
            _ChooseDialog.SelectedPath = this.txbxRimworldFolder.Text;
            DialogResult _Result = _ChooseDialog.ShowDialog();

            if (_Result == DialogResult.OK)
            {
                this.txbxRimworldFolder.Text = _ChooseDialog.SelectedPath;
            }
        }

        private void bttnChooseSaveFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog _ChooseDialog = new FolderBrowserDialog();
            _ChooseDialog.SelectedPath = this.txbxSaveFolder.Text;
            DialogResult _Result = _ChooseDialog.ShowDialog();

            if (_Result == DialogResult.OK)
            {
                this.txbxSaveFolder.Text = _ChooseDialog.SelectedPath;
            }
        }
    }
}
