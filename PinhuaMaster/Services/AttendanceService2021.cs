using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Data.Entities.EastRiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PinhuaMaster.Extensions;
using PinhuaMaster.Extensions.Converters;

namespace PinhuaMaster.Services
{
    public class AttendanceService2021 : IAttendanceService2021
    {
        private readonly PinhuaContext _pinhuaContext;
        private readonly EastRiverContext _eastRiverContext;
        public AttendanceService2021(PinhuaContext pinhuaContext, EastRiverContext eastRiverContext)
        {
            _pinhuaContext = pinhuaContext;
            _eastRiverContext = eastRiverContext;
        }

        public 模型_月考勤表 月考勤表(int Y, int M)
        {
            var firstDay = new DateTime(Y, M, 1);
            var lastDay = firstDay.AddMonths(1).AddSeconds(-1);

            var eastriver = _eastRiverContext.TimeRecords.AsNoTracking().Where(p => p.SignTime.Year == Y && p.SignTime.Month == M).ToList();
            // 正常打卡
            var records1 = (from f in _pinhuaContext.人员档案.AsNoTracking().ToList()
                            join c in _pinhuaContext.考勤卡号变动.AsNoTracking().ToList() on f.ExcelServerRcid equals c.ExcelServerRcid
                            join r in eastriver on c.卡号 equals r.CardId
                            where r.SignTime.IsBetween(firstDay, lastDay)
                            group new { f, c, r } by new { f.人员编号, f.姓名 } into g
                            select new 模型_考勤人
                            {
                                编号 = g.Key.人员编号,
                                姓名 = g.Key.姓名,
                                打卡数据 = g.Select(a => new 模型_打卡数据 { 卡号 = a.r.CardId, 时间 = a.r.SignTime }).ToList()
                            }).ToList();
            var obj = new 模型_月考勤表
            {
                年 = Y,
                月 = M,
                考勤人列表 = records1
            };
            return obj;
        }

    }

    public class 模型_打卡数据
    {
        public string 卡号 { get; set; }
        public DateTime 时间 { get; set; }
    }
    public class 模型_考勤人
    {
        public string 编号 { get; set; }
        public string 姓名 { get; set; }
        public IList<模型_打卡数据> 打卡数据 { get; set; }
    }

    public class 模型_年考勤表
    {
        public int 年 { get; set; }
        public IList<模型_考勤人> 考勤人列表 { get; set; }
    }

    public class 模型_月考勤表:模型_年考勤表
    {
        public int 月 { get; set; }
    }

    public class 模型_日考勤表 : 模型_月考勤表
    {
        public int 日 { get; set; }
    }
}
