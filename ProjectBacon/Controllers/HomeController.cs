using Newtonsoft.Json;
using ProjectBacon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProjectBacon.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            var listOfChecklistTypes = new Api_ChecklistTypeController().GetChecklistTypeRecords();

            return View(listOfChecklistTypes);
        }

    }
}

