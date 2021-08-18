using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class EmployeeAccount
    {
        public string EmpId { get; set; }
        public string CardId { get; set; }
        public int AccountId { get; set; }
        public DateTime? ExpireDate { get; set; }
        public decimal CardBalance { get; set; }
        public int CardSequ { get; set; }
        public int CardTimes { get; set; }
        public string OverPwd { get; set; }
        public int? MealOrder { get; set; }
        public decimal? MealMoney { get; set; }
        public int? MealTimes { get; set; }
        public decimal? DayMoney { get; set; }
        public int? DayTimes { get; set; }
        public decimal? DayConsume { get; set; }
        public decimal? DayMaxMoney { get; set; }
        public int? DayTime { get; set; }
        public decimal? TimeMaxMoney { get; set; }
        public decimal? DayTotalMoney { get; set; }
        public int? DayTotalTime { get; set; }
        public bool? IsOverTime { get; set; }
        public decimal? ChargeMoney { get; set; }
        public decimal? PreBalance { get; set; }
        public int? PreSequ { get; set; }
        public DateTime? ChargeDate { get; set; }
        public DateTime? LastDate { get; set; }
        public decimal? LastBalance { get; set; }
        public decimal EpOverDraft { get; set; }
        public decimal OnLineMaxJe { get; set; }
        public bool? IsLock { get; set; }
        public bool? IsWash { get; set; }
        public DateTime OpenDate { get; set; }
        public int AppState { get; set; }
        public bool? UsePwd { get; set; }
        public decimal? AllowanceBalance { get; set; }
        public bool? BOverDiffPeriod { get; set; }
        public decimal? NAccountBalance { get; set; }
        public int DayCount { get; set; }
        public int DayTotalCount { get; set; }
        public decimal DayTotalMoney1 { get; set; }
        public DateTime DayTotalDate { get; set; }
        public DateTime? AllowEndDate { get; set; }
        public int? NReturnTimes { get; set; }
        public DateTime? LastAccountDate { get; set; }
        public decimal? LastBalance1 { get; set; }
        public int? LastTransTimes { get; set; }

        public EmployeeCard Card { get; set; }
    }
}
