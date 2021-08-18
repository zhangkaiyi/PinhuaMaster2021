using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class Area
    {
        public string AreaId { get; set; }
        public string AreaName { get; set; }
        public int? Kind { get; set; }
        public string Remark { get; set; }
        public int AreaId1 { get; set; }
        public int PareaId { get; set; }
    }
}
