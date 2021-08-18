using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class AdJustHrsD
    {
        public int Id { get; set; }
        public string BillId { get; set; }
        public string EmpId { get; set; }
        public DateTime CurDate { get; set; }
        public DateTime LaterDate { get; set; }
        public decimal? HrsNum { get; set; }
        public string LaterBTime { get; set; }
        public string LaterETime { get; set; }
        public int? Kind { get; set; }
    }
}
