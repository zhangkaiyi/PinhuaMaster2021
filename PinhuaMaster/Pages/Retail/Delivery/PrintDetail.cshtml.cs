﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PinhuaMaster.Pages.Retail.Delivery
{
    public class PrintDetailModel : PageModel
    {
        public string Id { get; set; }
        public void OnGet(string Id)
        {
            this.Id = Id;
        }
    }
}