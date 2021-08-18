using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;

namespace PinhuaMaster.Pages.Statement
{
    public class IndexModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;

        public IndexModel(PinhuaContext pinhuaContext)
        {
            _pinhuaContext = pinhuaContext;
        }

        public List<往来单位> Customers { get; set; }

        public void OnGet()
        {
            Customers = _pinhuaContext.往来单位.AsNoTracking()
                .OrderByDescending(p => p.Rank)
                .ThenBy(p => p.单位编号)
                .ToList();
        }
    }
}