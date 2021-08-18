using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class EmployeeCard
    {
        public EmployeeCard()
        {
            EmployeeAccount = new HashSet<EmployeeAccount>();
        }

        public string EmpId { get; set; }
        public string CardId { get; set; }
        public string CardSn { get; set; }
        public int CardType { get; set; }
        public decimal CardBalance { get; set; }
        public string MobilePhone { get; set; }
        public string CardTypeCode { get; set; }
        public string AreaCode { get; set; }
        public int UseFlag { get; set; }
        public int WalletFlag { get; set; }
        public decimal DepositValue { get; set; }
        public int CustomerType { get; set; }
        public int EmpFlag { get; set; }
        public int CardState { get; set; }
        public string CardVerifyCode { get; set; }
        public bool? Issued { get; set; }
        public DateTime? IssueDate { get; set; }
        public bool? IsBlack { get; set; }
        public int BlackSequ { get; set; }
        public bool? IsWhite { get; set; }
        public DateTime? CardBegDate { get; set; }
        public DateTime? CardEndDate { get; set; }
        public int? Eeseq { get; set; }
        public string NewMobilePhone { get; set; }
        public string NewCardId { get; set; }
        public DateTime? ReIssueDate { get; set; }
        public string VQueryPwd { get; set; }
        public bool? IsMaster { get; set; }
        public int? ChPwdTimes { get; set; }
        public string GroupInfo { get; set; }
        public int? Privillege { get; set; }
        public string CardSnBak { get; set; }
        public int AllowanceSequ { get; set; }

        public ICollection<EmployeeAccount> EmployeeAccount { get; set; }
    }
}
