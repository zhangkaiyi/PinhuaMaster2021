using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class DinRoomMonthAccountBook
    {
        public string CAccMonth { get; set; }
        public DateTime? DBeginDate { get; set; }
        public DateTime? DEndDate { get; set; }
        public string CDinRoomId { get; set; }
        public decimal? NOpenBalance { get; set; }
        public decimal? NCloseBalance { get; set; }
        public decimal? NMorningAmount { get; set; }
        public int? NMorningTimes { get; set; }
        public decimal? NNoonAmount { get; set; }
        public int? NNoonTimes { get; set; }
        public decimal? NEveningAmount { get; set; }
        public int? NeveningTimes { get; set; }
        public decimal? NNightAmount { get; set; }
        public int? NNightTimes { get; set; }
        public decimal? NOtherAmount { get; set; }
        public int? NOtherTimes { get; set; }
        public decimal? NCardCharge { get; set; }
        public decimal? NCardReturn { get; set; }
        public decimal? NCashReceive { get; set; }
        public decimal? NCashPay { get; set; }
        public decimal? NOutCard { get; set; }
        public decimal? NAllowMeal { get; set; }
        public int? NCountMeal { get; set; }
        public int? NOutCountMeal { get; set; }
        public decimal? NCardInit { get; set; }
        public decimal? NOutFixMeal { get; set; }
        public decimal? NChargeBatch { get; set; }
        public decimal? NChargeReceive { get; set; }
        public decimal? NChargeAllow { get; set; }
        public decimal? NChargeBounds { get; set; }
        public decimal? NChargeFix { get; set; }
        public int? NMealMorning { get; set; }
        public int? NMealNoon { get; set; }
        public int? NMealEvening { get; set; }
        public int? NMealNight { get; set; }
        public int? NMealOther { get; set; }
        public decimal? NOrderMeal { get; set; }
        public decimal? CardCost { get; set; }
        public decimal? Maintenance { get; set; }
        public decimal? CardCostOut { get; set; }
        public decimal? MaintenanceOut { get; set; }
        public decimal? OpenCardCost { get; set; }
        public decimal? OpenMaintenance { get; set; }
        public decimal? CloseCardCost { get; set; }
        public decimal? CloseMaintenance { get; set; }
        public decimal NMealMoAmount { get; set; }
        public decimal NMealNoAmount { get; set; }
        public decimal NMealEvAmount { get; set; }
        public decimal NMealNiAmount { get; set; }
        public decimal NMealOtAmount { get; set; }
        public decimal NChargeReturn { get; set; }
        public decimal? NQuanCash { get; set; }
        public decimal? NReIssueCash { get; set; }
    }
}
