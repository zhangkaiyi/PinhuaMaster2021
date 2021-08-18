using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class Job
    {
        public string JobId { get; set; }
        public string JobName { get; set; }
        public short? Privillege { get; set; }
        public int? JobLevel { get; set; }
    }
}
