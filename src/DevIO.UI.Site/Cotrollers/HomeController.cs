using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.UI.Site.Cotroller
{
    public class HomeControllercs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
