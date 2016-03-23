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

        private void frmMain_Load(object sender, EventArgs e)
        {
            RimworldModOrginiser.DataObjects.Mod testMod = new RimworldModOrginiser.DataObjects.Mod();
            testMod.load(@"C:\Games\RimWorldAlpha12dWin\RimWorld914Win\Mods\Core");
        }
    }
}
