using System;
using System.Collections.Generic;
using PinhuaMaster.Data.Entities.Pinhua;

namespace PinhuaMaster.Services
{
    public interface IAttendanceService
    {
        AttendanceServiceDTO GetAttendanceData(int? Y, int? M);
        AttendanceServiceDTO GetExsitedAttendanceData(int? Y, int? M);
        IList<AttendanceTimeRecords> GetTimeRecrods(int Y, int M);
    }
}