using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adminty.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Accordion()
        {
            return View();
        }
        public IActionResult Crm()
        {
            return View();
        }
        public IActionResult Analytics()
        {
            return View();
        }
        public IActionResult MenuStatic()
        {
            return View();
        }
        public IActionResult MenuHeaderFixed()
        {
            return View();
        }
        public IActionResult MenuCompact()
        {
            return View();
        }
        public IActionResult MenuSidebar()
        {
            return View();
        }
    }
}
