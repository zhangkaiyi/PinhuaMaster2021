using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.EastRiver;
using PinhuaMaster.Data.Entities.Pinhua;

namespace PinhuaMaster.Pages.Attendance.EastRiver
{
    public class DetailsModel : PageModel
    {
        private readonly EastRiverContext _eastRiverContext;
        private readonly PinhuaContext _pinhuaContext;

        public DetailsModel(EastRiverContext eastRiverContext, PinhuaContext pinhuaContext)
        {
            _eastRiverContext = eastRiverContext;
            _pinhuaContext = pinhuaContext;
        }

        public IEnumerable<DTO> timeRecords { get; set; }

        public IActionResult OnGet(int? year, int? month, string id)
        {
            if (year == null || month == null)
                return NotFound();

            var users = (from u in _pinhuaContext.人员档案.AsNoTracking()
                         join c in _pinhuaContext.考勤卡号变动.AsNoTracking() on u.ExcelServerRcid equals c.ExcelServerRcid
                         select new
                         {
                             Id = u.人员编号,
                             Name = u.姓名,
                             CardNo = c.卡号
                         }).ToList();


            if (string.IsNullOrEmpty(id))
            {
                timeRecords = from r in _eastRiverContext.TimeRecords.AsNoTracking().Where(r => r.SignTime.Year == year && r.SignTime.Month == month)
                              join user in users on r.CardId equals user.CardNo
                              select new DTO
                              {
                                  Id = user.Id,
                                  Name = user.Name,
                                  CardNo = user.CardNo,
                                  SignTime = r.SignTime,
                                  RecordId = r.Id,
                              };
                return Page();
            }
            else
            {
                var user = users.Where(p => p.Id == id);
                if (user == null)
                    return NotFound();
                else
                {
                    timeRecords = from p in _eastRiverContext.TimeRecords.AsNoTracking()
                                  join c in user on p.CardId equals c.CardNo
                                  where p.SignTime.Year == year && p.SignTime.Month == month
                                  select new DTO
                                  {
                                      Id = c.Id,
                                      Name = c.Name,
                                      CardNo = c.CardNo,
                                      RecordId = p.Id,
                                      SignTime = p.SignTime,
                                  };
                    return Page();
                }
            }
        }
    }

    public class DTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CardNo { get; set; }
        public int RecordId { get; set; }
        public DateTime SignTime { get; set; }
    }
}