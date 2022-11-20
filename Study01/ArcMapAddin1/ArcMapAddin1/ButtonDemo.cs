using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ArcMapAddin1
{
    public class ButtonDemo : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public ButtonDemo()
        {
        }

        protected override void OnClick()
        {
            //
            //  TODO: Sample code showing how to access button host
            //
            ArcMap.Application.CurrentTool = null;
        }
        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }

}
