using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinhuaMaster.Data.Entities.EastRiver;
using PinhuaMaster.Data.Entities.Pinhua;

namespace PinhuaMaster.Pages.Attendance.EastRiver
{
    public class DeleteModel : PageModel
    {
        private readonly EastRiverContext _eastRiverContext;
        private readonly PinhuaContext _pinhuaContext;

        public DeleteModel(EastRiverContext eastRiverContext, PinhuaContext pinhuaContext)
        {
            _eastRiverContext = eastRiverContext;
            _pinhuaContext = pinhuaContext;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost(int Id)
        {
            var result = _eastRiverContext.TimeRecords.FirstOrDefault(p => p.Id == Id);
            var year = result.SignTime.Year;
            var month = result.SignTime.Month;
            var cardid = result.CardId;
            var personId = (from p in _pinhuaContext.人员档案
                            join c in _pinhuaContext.考勤卡号变动 on p.ExcelServerRcid equals c.ExcelServerRcid
                            where c.卡号 == cardid
                            select p)
                            .FirstOrDefault()?.人员编号;

            _eastRiverContext.TimeRecords.Remove(result);
            _eastRiverContext.SaveChanges();
            return RedirectToPage("Details", new { year, month, id = personId });
        }
    }
}