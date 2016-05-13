using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.WebEncoders;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace EvClientv1.Controllers
{
    public class EvClientHomeController : Controller
    {
        /* GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        */

        // GET: /EvClientHome/ 

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /EvClientHome/Welcome/ 

        public string Welcome(string name, int numtimes = 1, int id = 1)
        {
            return HtmlEncoder.Default.HtmlEncode(
                "Hello " + name + ", ID: " + id + " and numtimes: " + numtimes);
        }
    }
}
