using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class EsIdRec
    {
        public int StdId { get; set; }
        public string Prefix { get; set; }
        public int MaxNum { get; set; }
        public DateTime GenDate { get; set; }
    }
}
