using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace officenet.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet("contact")]
        public IActionResult Index()
        {
            return View("~/Views/Employee/contact.cshtml");
        }
    }
}
