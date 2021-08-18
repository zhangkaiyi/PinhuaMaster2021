using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class TransCorrect
    {
        public string CTransCode { get; set; }
        public string CEmpId { get; set; }
        public string CCardId { get; set; }
        public int NAccountId { get; set; }
        public DateTime? DTransDate { get; set; }
        public int NTransTimes { get; set; }
        public decimal? NTransAmount { get; set; }
        public decimal? NCharge { get; set; }
        public decimal? NAllow { get; set; }
        public long? NTransSeq { get; set; }
        public bool? Doflag { get; set; }
    }
}
