using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimworldModOrginiser.ProgramSettings
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

        public string SaveFolder
        {
            get
            {
                return this.m_SaveFolder;
            }
            set
            {
                this.m_SaveFolder = value;
            }
        }
        string m_SaveFolder;

        public override string ToString()
        {
            return "RimworldFolder: " + this.RimworldFolder + Environment.NewLine + " SaveFolder: " + this.SaveFolder;
            //return base.ToString(); 
        }

    }
}
