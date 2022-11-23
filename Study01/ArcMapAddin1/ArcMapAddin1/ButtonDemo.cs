using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Framework;
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

            // 7: Code đổi tên Map
            IMxDocument mxdoc = ArcMap.Document;// as IMxDocument;
            IMap map = mxdoc.FocusMap;
            map.Name = "My New Map 2";

            // 8: Refresh TOC
            IContentsView contentsView = mxdoc.ContentsView[0];
            contentsView.Refresh(null);
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
