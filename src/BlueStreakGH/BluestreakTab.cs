using System;
using Grasshopper.Kernel;

namespace Bluestreak
{
    class BluestreakTab: GH_AssemblyPriority
    {

        public override GH_LoadingInstruction PriorityLoad()
        {
            Grasshopper.Instances.ComponentServer.AddCategoryShortName("Bluestreak", "BS");
            Grasshopper.Instances.ComponentServer.AddCategorySymbolName("Bluestreak",'B');
            //Grasshopper.Instances.ComponentServer.AddCategoryIcon("NudiBranch", My.Resources.myicon);
            return GH_LoadingInstruction.Proceed;
        }
    }
}