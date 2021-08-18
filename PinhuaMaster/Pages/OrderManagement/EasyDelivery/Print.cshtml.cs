using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PinhuaMaster.Pages.OrderManagement.EasyDelivery
{
    public class PrintModel : PageModel
    {
        public string Id { get; set; }
        public void OnGet(string Id, string printMode)
        {
            this.Id = Id;
        }
    }
}