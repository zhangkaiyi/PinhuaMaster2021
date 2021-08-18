using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class UserMonthAccountBook
    {
        public string CAccMonth { get; set; }
        public DateTime? DBeginDate { get; set; }
        public DateTime? DEndDate { get; set; }
        public string CEmpId { get; set; }
        public string CCardId { get; set; }
        public int NAccountId { get; set; }
        public decimal? NOpenBalance { get; set; }
        public decimal? NCloseBalance { get; set; }
        public decimal? NInCash { get; set; }
        public decimal? NInAllow { get; set; }
        public decimal? NInClear { get; set; }
        public decimal? NInGrayAllow { get; set; }
        public decimal? NInBatch { get; set; }
        public decimal? NInReceive { get; set; }
        public decimal? NInBounds { get; set; }
        public decimal? NOutConsume { get; set; }
        public decimal? NOutOrderConsume { get; set; }
        public decimal? NOutCancelMeal { get; set; }
        public decimal? NOutInput { get; set; }
        public decimal? NOutReturnCash { get; set; }
        public decimal? NOutModify { get; set; }
        public decimal? NInGrayAllowCash { get; set; }
        public decimal? NInFixCharge { get; set; }
        public decimal? NOutFixMeal { get; set; }
        public decimal? NInInit { get; set; }
        public decimal? NOutGrayMeal { get; set; }
        public decimal? NInGrayMealCash { get; set; }
        public int? NCountMeal { get; set; }
        public int? NOuterCountMeal { get; set; }
        public decimal? NOuterConsume { get; set; }
        public decimal? NAllowMeal { get; set; }
        public decimal? NOrderMeal { get; set; }
        public decimal? CardCost { get; set; }
        public decimal? Maintenance { get; set; }
        public decimal? CardCostOut { get; set; }
        public decimal? MaintenanceOut { get; set; }
        public decimal? OpenCardCost { get; set; }
        public decimal? OpenMaintenance { get; set; }
        public decimal? CloseCardCost { get; set; }
        public decimal? CloseMaintenance { get; set; }
        public decimal NOffLine { get; set; }
        public decimal NOnLine { get; set; }
        public decimal NOutCash { get; set; }
        public decimal? NLoseAmount { get; set; }
        public string DepartId { get; set; }
        public string CEmpName { get; set; }
        public decimal? NQuanCash { get; set; }
        public decimal? NReIssueCash { get; set; }
    }
}
