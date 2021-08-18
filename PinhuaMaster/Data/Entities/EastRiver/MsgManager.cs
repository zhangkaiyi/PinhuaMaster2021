using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class MsgManager
    {
        public string Mid { get; set; }
        public string EmpNo { get; set; }
        public string CardNo { get; set; }
        public string MobilePhone { get; set; }
        public string AppIdx { get; set; }
        public string Mcode { get; set; }
        public string TransId { get; set; }
        public string Details { get; set; }
        public int SendState { get; set; }
        public int DealState { get; set; }
        public DateTime? SendTime { get; set; }
        public DateTime? ReceiveTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
    }
}
