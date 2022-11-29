using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace LayersOfMap
{
    public class FeaterLayerInspector : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public FeaterLayerInspector()
        {
        }

        protected override void OnClick()
        {
            string data = "";
            IMxDocument mxDoc = ArcMap.Application.Document as IMxDocument;
            ILayer selectedLayer = mxDoc.SelectedLayer;

            if(selectedLayer != null)
            {
                // using interface IFeatureLayer2
                IFeatureLayer2 selectedFL = selectedLayer as IFeatureLayer2;
                data += "Data Source Type: " + selectedFL.DataSourceType + "\n";
                data += "ShapeTypes: " + selectedFL.ShapeType + "\n";
                data += "Is Selectable? " + selectedFL.Selectable + "\n";
                data += "Primary Display Field: " + selectedFL.DisplayField + "\n";

                // using ILayerFields
                ILayerFields selectedLayerFields = selectedFL as ILayerFields;
                data += "field count: " + selectedLayerFields.FieldCount + "\n";
                data += "Third field Name: " + selectedLayerFields.Field[2] + "\n";

                // using IFeoFeatureLayer
                IGeoFeatureLayer selectedGFL = selectedFL as IGeoFeatureLayer;
                //toggle labeling for selected layer
                if(selectedGFL.DisplayAnnotation == true)
                {
                    selectedGFL.DisplayAnnotation = false;
                } else
                {
                    selectedGFL.DisplayAnnotation = true;
                }

                // since you modify rendering of the map by toggling labeling
                // need to refresh the map
                mxDoc.ActivatedView.Refresh();

                Message msgForm = new Message();
                msgForm.lbl.Text = data;
                msgForm.ShowDialog();


            }    

        }

        protected override void OnUpdate()
        {
        }
    }
}
