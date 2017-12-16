using System;
using System.Collections.Generic;
using System.Net;

using Grasshopper.Kernel;
//if we were to add graphical imput
using Rhino.Geometry;


namespace Bluestreak
{
    public class BluestreakCryptos : GH_Component
    {
        /// <summary>
        /// A component to track your favourite cryprocurency market rates
        /// Fetching data from coinmarketcap.com 
        /// top 10 cryptos are pre-selected, use a custom string to target one thats not available
        /// refresh rate 30000 ms otherwise your IP address will be blocked
        /// </summary>
        public BluestreakCryptos()
          : base("Cryptos", "Cryptos",
              "Track your favourite cryptocurrency",
              "Extra", "Bluestreak")
        {
        }

        /// <summary>
        /// Register inputs.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
        }

        /// <summary>
        /// Register Outputs.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.Register_StringParam("debug", "debugging", "this outputs a random message for debugging the code");
        }

        /// <summary>
        /// Main Routine
        /// to store data in output parameters.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            string myMes;
            myMes = "this is just a debugging test";

            DA.SetData(0, myMes);
        }

        /// <summary>
        ///component Icon
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                // ToDO: Icon development
                //return Resources.blueStreakIcon;
                return null;
            }
        }

        /// <summary>
        /// Unique Guid
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("b87d5f94-d4e9-4afc-89f0-e0570daf495b"); }
        }
    }
}
