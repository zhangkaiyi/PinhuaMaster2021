using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class Users
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string GroupName { get; set; }
        public bool IsNew { get; set; }
        public bool IsStop { get; set; }
        public string Access { get; set; }
        public string Clocks { get; set; }
        public string Departs { get; set; }
        public string RealClocks { get; set; }
        public DateTime? LoginTime { get; set; }
        public string LoginComputer { get; set; }
        public string LoginIp { get; set; }
        public string LoginMachineCode { get; set; }
        public int? Mincardno { get; set; }
        public int? Maxcardno { get; set; }
        public int? IssueCardNo { get; set; }
        public int? MincardempId { get; set; }
        public int? MaxcardempId { get; set; }
        public int? IssueEmpId { get; set; }
        public bool? IsSlesctAllFullMoney { get; set; }
        public int? ModifyConsumeErrTime { get; set; }
        public bool? AccRemind { get; set; }
        public bool? LogonFront { get; set; }
    }
}
