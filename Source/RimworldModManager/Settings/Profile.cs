using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimworldModManager.ProgramSettings
{
    public class Profile
    {

        public string RimworldFolder
        {
            get
            {
                return this.m_RimworldFolder;
            }
            set
            {
                this.m_RimworldFolder = value;
            }
        }
        string m_RimworldFolder;

        public string ConfigFolder
        {
            get
            {
                return this.m_ConfigFolder;
            }
            set
            {
                this.m_ConfigFolder = value;
            }
        }
        string m_ConfigFolder;

        public override string ToString()
        {
            return "RimworldFolder: " + this.RimworldFolder + Environment.NewLine + " ConfigFolder: " + this.ConfigFolder;
            //return base.ToString(); 
        }

    }
}
