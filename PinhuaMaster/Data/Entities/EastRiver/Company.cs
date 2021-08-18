using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class Company
    {
        public string CompanyId { get; set; }
        public string CompanyChName { get; set; }
        public string CompanyEnName { get; set; }
        public string CompanyAddress { get; set; }
        public string PhoneCode { get; set; }
        public string FaxCode { get; set; }
        public string Principal { get; set; }
        public string MachineCode { get; set; }
        public string SerialNo { get; set; }
        public string Manager { get; set; }
        public string Parameters { get; set; }
        public byte[] Logo { get; set; }
        public byte[] LateImage { get; set; }
        public byte[] LeaveImage { get; set; }
        public byte[] NocardImage { get; set; }
        public int? ImageSize { get; set; }
        public string RealColor { get; set; }
        public string Textfmt { get; set; }
        public string Timeparam { get; set; }
        public string CompanyHttp { get; set; }
        public string CompanyLoginName { get; set; }
        public string SetFont { get; set; }
        public string SetColor { get; set; }
        public string BuildDate { get; set; }
        public string VersionId { get; set; }
        public bool? IsRealMeal { get; set; }
        public string SystemList { get; set; }
        public int MultiDoorCardNoRule { get; set; }
        public string CpucardParam { get; set; }
        public string DataKey { get; set; }
        public int? DepartLast { get; set; }
        public short? NAccountPeriod { get; set; }
        public int? VerNo { get; set; }
        public bool? BBusinessState { get; set; }
        public DateTime? DPrevAccDate { get; set; }
        public DateTime? DCurrAccDate { get; set; }
        public DateTime? DNextAccDate { get; set; }
        public int? NBookType { get; set; }
        public string CBookTime { get; set; }
        public int? NAcceptDiffDays { get; set; }
        public int? NReIssueDelay { get; set; }
        public bool? BTakeMoneyCheck { get; set; }
        public int? NMaxLost { get; set; }
        public DateTime? DInitDate { get; set; }
        public int FreqType { get; set; }
        public int FreqInterval { get; set; }
        public int FreqRecurrenceFactor { get; set; }
        public string BackupDb { get; set; }
        public DateTime StartTime { get; set; }
    }
}
