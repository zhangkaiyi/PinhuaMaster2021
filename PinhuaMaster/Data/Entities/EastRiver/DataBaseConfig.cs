using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class DataBaseConfig
    {
        public int DbId { get; set; }
        public string ServerName { get; set; }
        public string DbName { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int IsTrust { get; set; }
    }
}
