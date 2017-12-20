using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace Bluestreak
{
    public class BluestreakInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "Bluestreak";
            }
        }
        public override string Version
        {
            get
            {
                return "1.00";
;            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Bluestreak icon 24x24 colour
                //return my.Resources.bluestreakIcon;
                return null;
            }
        }
        public override string Description
        {
            get
            {
                return "BlueStreak offers a a direct link to your cryptocurrency rates within your favourite visual programming platform";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("a73101fa-c455-4aff-b2fc-2cd7e9ccb956");
            }
        }

        public override string AuthorName
        {
            get
            {
                return "Marios Tsiliakos, Tarek Hassan, Fillipos Fillipidis";
            }
        }
        public override string AuthorContact
        {
            get
            {
                return "www.digitalsubstance.wordpress.com/";
            }
        }
    }
}
