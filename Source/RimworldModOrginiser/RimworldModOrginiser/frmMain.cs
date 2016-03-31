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
        RimworldModOrginiser.DataObjects.Manager m_Manager;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        #region Gui Events

        private void bttnLoad_Click(object sender, EventArgs e)
        {
            this.m_Manager = new RimworldModOrginiser.DataObjects.Manager();

            this.m_Manager.LoadModList(@"C:\Games\RimWorldAlpha12dWin\RimWorld914Win");

            this.m_Manager.LoadModConfig(@"C:\Games\RimWorld1123WinDev\SaveData");

            //this.bsrcModDetails.DataSource = this.m_Manager.ModList;


            this.UpdateOrder();
        }

        private void toolModGrid_MoveUp_Click(object sender, EventArgs e)
        {
            this.FullSelect();
            foreach (DataGridViewRow _CurrentRow in dgrvMods.SelectedRows)
            {
                DataObjects.ModDetails _CurrentMod = (DataObjects.ModDetails)_CurrentRow.DataBoundItem;

                this.m_Manager.MoveModUp(_CurrentMod);
            }

            //Update grid sequence
            this.UpdateOrder();
            //Reselect
        }

        private void toolModGrid_MoveDown_Click(object sender, EventArgs e)
        {

            this.FullSelect();

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
        }

        private void toolModGrid_Toggle_Click(object sender, EventArgs e)
        {

            this.FullSelect();

            foreach (DataGridViewRow _CurrentRow in dgrvMods.SelectedRows)
            {
                DataObjects.ModDetails _CurrentMod = (DataObjects.ModDetails)_CurrentRow.DataBoundItem;
                this.m_Manager.Toggle(_CurrentMod);
            }
            this.UpdateOrder();
        }
        

        private void UpdateOrder()
        {

            this.m_Manager.Reorder();
            dgrvMods.DataSource = null;
            dgrvMods.DataSource = m_Manager.ModList;
            dgrvMods.Refresh();
        }

        #endregion

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

    }
}