using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PinhuaMaster.Pages.OrderManagement.Old.DeliveryOrder
{
    public class DetailsModel : PageModel
    {
        public string DeliveryId { get; set; }

        public void OnGet(string Id)
        {
            DeliveryId = Id;
        }
    }
}