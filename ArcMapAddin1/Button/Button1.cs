using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Button
{
    public class Button1 : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public Button1()
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

        public void GetMxDocument()
        {
            //IMxDocument doc = ArcMap.Application.Document;
            IMxDocument mxdoc = ArcMap.Document as IMxDocument;

        }

        public void GetMap()
        {
            IDocument doc = ArcMap.Application.Document;

            //cast to IMxDocument interface
            IMxDocument mxdoc = doc as IMxDocument;

            IMap map = mxdoc.FocusMap;

        }
    }

}
