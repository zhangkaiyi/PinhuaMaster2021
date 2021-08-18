using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class AreaConfig
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsDefault { get; set; }
        public string Note { get; set; }
    }
}
