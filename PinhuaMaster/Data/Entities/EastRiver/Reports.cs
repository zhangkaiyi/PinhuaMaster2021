using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class Reports
    {
        public int Id { get; set; }
        public string FormName { get; set; }
        public string RepName { get; set; }
        public byte[] Content { get; set; }
        public string LanCode { get; set; }
    }
}
