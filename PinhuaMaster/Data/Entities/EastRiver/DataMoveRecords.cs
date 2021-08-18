using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class DataMoveRecords
    {
        public long NRecSeq { get; set; }
        public DateTime DDmdate { get; set; }
        public string COperator { get; set; }
        public DateTime DOperateTime { get; set; }
        public int NOpState { get; set; }
        public string CDescription { get; set; }
        public DateTime NOpTime { get; set; }
        public int NOpFlag { get; set; }
    }
}
