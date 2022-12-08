using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESRI.ArcGIS.Geodatabase;

namespace Bai32AddInArcMap
{
    class fldClass
    {
        public int No { get; set; }
        public string AliasName { get; set; }
        public string Name { get; set; }
        public esriFieldType FieldType { get; set; }
        public int Length { get; set; }
        public bool IsRequired { get; set; }
        public string IsNullable { get; set; }

        public fldClass(int No)
        {
            this.No = No;
        }

    }
}
