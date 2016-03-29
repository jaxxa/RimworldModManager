using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RimworldModOrginiser.DataObjects
{
    class Manager
    {
        public List<ModDetails> ModList
        {
            get
            {
                return this.m_ModList;
            }
            set
            {
                this.m_ModList = value;
            }
        }
        List<ModDetails> m_ModList = new List<ModDetails>();

        public void LoadModList(string rwFolder)
        {
            this.m_ModList.Clear();

            // Check that the Rimworld Folder exists
            if (!System.IO.Directory.Exists(rwFolder))
            {
                MessageBox.Show("Rimworld Folder not Found" + rwFolder);
                return;
            }

            string _RimworldModsFolder = rwFolder + @"\Mods";
            //Check mods folder exists
            if (!System.IO.Directory.Exists(_RimworldModsFolder))
            {
                MessageBox.Show("Mods Folder not Found" + _RimworldModsFolder);
                return;
            }

            //Find all mods (folders in mods folder)
            System.IO.DirectoryInfo _RimworldModsFolderInfo = new System.IO.DirectoryInfo(_RimworldModsFolder);

            System.IO.DirectoryInfo[] _ModFolders = _RimworldModsFolderInfo.GetDirectories();

            foreach (System.IO.DirectoryInfo _ModDirectoryInfo in _ModFolders)
            {
                RimworldModOrginiser.DataObjects.ModDetails _CurrentMod = new RimworldModOrginiser.DataObjects.ModDetails();
                _CurrentMod.load(_ModDirectoryInfo.FullName);

                this.m_ModList.Add(_CurrentMod);
            }
        }

        public void LoadModConfig(string saveFolder)
        {

            // Check that the Save Folder exists
            if (!System.IO.Directory.Exists(saveFolder))
            {
                MessageBox.Show("Save Folder not Found: " + saveFolder);
                return;
            }

            string _RimworldConfigFolder = saveFolder + @"\Config";
            //Check mods folder exists
            if (!System.IO.Directory.Exists(_RimworldConfigFolder))
            {
                MessageBox.Show("Config Folder not Found:" + _RimworldConfigFolder);
                return;
            }

            //Check File
            string _ModsConfigFilePath = _RimworldConfigFolder + @"\ModsConfig.xml";
            if (!System.IO.File.Exists(_ModsConfigFilePath))
            {
                MessageBox.Show("Mod Config File not Found:" + _ModsConfigFilePath);
                return;
            }

        }

    }
}