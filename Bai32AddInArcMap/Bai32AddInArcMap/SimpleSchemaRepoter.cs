using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;


namespace Bai32AddInArcMap
{
    public class SimpleSchemaRepoter : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public SimpleSchemaRepoter()
        {
        }

        protected override void OnClick()
        {
            //
            //  TODO: Sample code showing how to access button host
            //
            ArcMap.Application.CurrentTool = null;

            IMxDocument mxDoc = ArcMap.Application.Document as IMxDocument;

            if(mxDoc.SelectedItem is IFeatureLayer2 || mxDoc.SelectedItem is ITable)
            {
                ITable selectionTbl = mxDoc.SelectedItem as ITable;
                //reportSchema(selectionTbl);
            }    
        }
        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }

}
