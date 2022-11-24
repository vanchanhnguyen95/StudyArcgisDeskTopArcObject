using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LayersOfMap
{
    public class LayersOfMapBtn : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public LayersOfMapBtn()
        {
        }

        protected override void OnClick()
        {
            //
            //  TODO: Sample code showing how to access button host
            //
            ArcMap.Application.CurrentTool = null;

            string data = string.Empty;

            IDocument doc = ArcMap.Application.Document;
            IMxDocument mxdoc = doc as IMxDocument;

            IMap map = mxdoc.FocusMap;

            // using layersCount property
            data += "Using LayersCount Property \n";

            ILayer layer;
            for(int i= 0; i < map.LayerCount; i++)
            {
                layer = map.Layer[i];
                data += " >> " + layer.Name + "\n";
            }

            // terminating layer object
            layer = null;
            data += string.Format("{0} Map contains {1} Layers\n", map.Name, map.LayerCount);
            data += "-----------------------------------------\n";
            data += "Using Layer Property \n";

            IEnumLayer enumLayer = map.Layers;
            layer = enumLayer.Next();
            int j = 0;
            while (layer!= null)
            {
                j++;
                data += " >> " + layer.Name + "\n";
                layer = enumLayer.Next();
            }
            data += string.Format("{0} Map contains {1} Layers\n", map.Name, j);

            Message msgForm = new Message();
            msgForm.lbl.Text = data;
            msgForm.ShowDialog();

        }
        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }

}
