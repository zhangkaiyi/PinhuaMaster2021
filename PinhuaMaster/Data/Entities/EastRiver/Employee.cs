using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class Employee
    {
        public string EmpId { get; set; }
        public string CardId { get; set; }
        public string EmpFname { get; set; }
        public int Idtype { get; set; }
        public string IdCard { get; set; }
        public bool NoSign { get; set; }
        public string DepartId { get; set; }
        public string JobId { get; set; }
        public string RuleId { get; set; }
        public string EduId { get; set; }
        public string NativeId { get; set; }
        public string NationId { get; set; }
        public string StatusId { get; set; }
        public int? CardKind { get; set; }
        public bool? PutUp { get; set; }
        public string DormId { get; set; }
        public string BedId { get; set; }
        public string GroupId { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Sex { get; set; }
        public string Marriage { get; set; }
        public string Email { get; set; }
        public string PhoneCode { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string LinkMan { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? ContractDate { get; set; }
        public DateTime? ContractOverDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        public string DimissionTypeId { get; set; }
        public string LeaveCause { get; set; }
        public decimal? PreBalance { get; set; }
        public int? PreSequ { get; set; }
        public bool? Icid { get; set; }
        public int? RestKind { get; set; }
        public string RestDays { get; set; }
        public int? WorktimeKind { get; set; }
        public string Shifts { get; set; }
        public string ShiftId { get; set; }
        public decimal? WorkHrs { get; set; }
        public byte[] Photo { get; set; }
        public string Remark { get; set; }
        public bool? ZlgputUp { get; set; }
        public int? AccessLevel { get; set; }
        public string AccessPwd { get; set; }
        public string ContactPhone { get; set; }
        public bool? Bless { get; set; }
        public string Foodtype { get; set; }
        public string GraduateCollege { get; set; }
        public string Specialty { get; set; }
        public string Introducer { get; set; }
        public DateTime? RedeployDate { get; set; }
        public DateTime? RedeployDate2 { get; set; }
        public decimal? WorkAge { get; set; }
        public string WorkStatus { get; set; }
        public DateTime? SocialInsuranceDate { get; set; }
        public decimal? SocialInsuranceMoney { get; set; }
        public bool? AuotShift { get; set; }
        public int? InworkAge { get; set; }
        public int? Age { get; set; }
        public DateTime? StopSocialInsuranceDate { get; set; }
        public DateTime? StopJobDate { get; set; }
        public DateTime? LongHolidayDate { get; set; }
        public string ContractLabour { get; set; }
        public DateTime? BeRegularDate { get; set; }
        public string DormBuilding { get; set; }
        public string SalaryAcount { get; set; }
        public string PassWord { get; set; }
        public string BankNo { get; set; }
        public bool? IsBlack { get; set; }
        public bool? IsWhite { get; set; }
        public DateTime? BalanceTime { get; set; }
        public decimal? DayConsume { get; set; }
        public decimal? DayMaxMoney { get; set; }
        public int? DayTime { get; set; }
        public decimal? TimeMaxMoney { get; set; }
        public decimal? DayTotalMoney { get; set; }
        public int? DayTotalTime { get; set; }
        public bool? IsOverTime { get; set; }
    }
}
