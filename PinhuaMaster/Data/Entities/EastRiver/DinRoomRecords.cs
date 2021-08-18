using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class DinRoomRecords
    {
        public long NRecSeq { get; set; }
        public string CVoucherNo { get; set; }
        public DateTime DTransTime { get; set; }
        public string CDinRoomId { get; set; }
        public string CTransCode { get; set; }
        public int NTransTimes { get; set; }
        public decimal NAmount { get; set; }
        public string COperator { get; set; }
        public bool? BAudit { get; set; }
        public DateTime? DAuditDate { get; set; }
        public string CAuditor { get; set; }
        public bool? BprintVoucher { get; set; }
        public DateTime? DAccDate { get; set; }
        public string CRemark { get; set; }
    }
}
