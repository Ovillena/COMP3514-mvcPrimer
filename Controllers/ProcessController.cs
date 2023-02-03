using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mvcPrimer.Controllers
{
    public class ProcessController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Process Page";

            Process[] stuffRunningOnComp = Process.GetProcesses();
            var processes = stuffRunningOnComp.
                OrderBy(p => p.Id);
            ViewBag.Stuff = stuffRunningOnComp;

            return View();
        }

        public IActionResult Index2()
        {
            ViewBag.Title = "Process Page";

            Process[] stuffRunningOnComp = Process.GetProcesses();
            

            return View(stuffRunningOnComp);
        }

        public IActionResult Display(int id)
        {

            ViewBag.Data = Process.GetProcessById(id);
            return View();

        }
    }
}
