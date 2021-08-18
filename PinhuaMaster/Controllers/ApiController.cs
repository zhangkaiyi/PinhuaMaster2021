using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PinhuaMaster.Data;

namespace PinhuaMaster.Controllers
{
    [Route("[controller]/[action]")]
    public class ApiController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger _logger;

        public ApiController(SignInManager<ApplicationUser> signInManager, ILogger<AccountController> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        public void GetNavMenu()
        {

        }
    }
}
