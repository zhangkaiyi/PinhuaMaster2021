using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;
using PinhuaMaster.Data.Entities.Pinhua;

namespace PinhuaMaster.Controllers
{
    public class PinhuaImageController : Controller
    {
        private PinhuaContext _pinhuaContext { get; set; }

        public PinhuaImageController(PinhuaContext pinhuaContext)
        {
            _pinhuaContext = pinhuaContext;
        }

        public IActionResult Image(string picNo, string contentType)
        {
            var esCasePic = _pinhuaContext.EsCasePic.FirstOrDefault(p => p.PicNo == picNo);
            if (esCasePic == null)
                return NoContent();
            return File(esCasePic.Img, contentType); 
        }
    }
}
