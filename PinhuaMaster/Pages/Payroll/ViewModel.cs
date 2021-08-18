using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PinhuaMaster.Pages.Payroll.ViewModel
{
    public class AttendanceData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<考勤明细> Details { get; set; }
    }

    public class AttendanceReportDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal? DaytimeHours { get; set; }
        public decimal? OvertimeHours { get; set; }
        public decimal? AllHours { get; set; }
        public int? DaysOfLeave { get; set; }
        public int? DaysOfWork { get; set; }
        public int? TimesOfDinner { get; set; }
        public bool IsFullAttendance { get; set; }
        public string Sex { get; set; }
    }

    public class PayrollDetailsDTO : AttendanceReportDTO
    {
        public string Post { get; set; }
        public string PriceOverview { get; set; }
        public decimal? DaytimeAmount { get; set; }
        public decimal? OvertimeAmount { get; set; }
        public decimal? AllHoursAmountWithFullAttendance { get; set; }
        public decimal? FullAttendanceAmount { get; set; }
        public decimal? DinnerAmount { get; set; }
        public decimal? FinalAmount { get; set; }
    }

    public class PayrollProfile : Profile
    {
        public PayrollProfile()
        {
            CreateMap<PayrollDetails, PayrollDetailsDTO>()
                .ForMember(dst => dst.AllHoursAmountWithFullAttendance, map => map.MapFrom(src => src.DaytimeAmount + src.OvertimeAmount + src.FullAttendanceAmount))
                .ForMember(dst => dst.IsFullAttendance, map => map.MapFrom(src => src.IsFullAttendance == "是" ? true : false));
            CreateMap<PayrollDetailsDTO, PayrollDetails>()
                .ForMember(dst => dst.IsFullAttendance, map => map.MapFrom(src => src.IsFullAttendance ? "是" : "否"));
        }
    }
}
