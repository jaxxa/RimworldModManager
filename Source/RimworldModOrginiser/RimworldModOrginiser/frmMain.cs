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
            this.m_Manager = new RimworldModOrginiser.DataObjects.Manager();
            this.m_Manager.load(@"C:\Games\RimWorldAlpha12dWin\RimWorld914Win");

            this.bsrcModDetails.DataSource = this.m_Manager.ModList;
        }
    }
}
