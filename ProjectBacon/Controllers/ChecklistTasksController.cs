using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectBacon.Controllers
{
    public class ChecklistTasksController : Controller
    {
        // GET: ChecklistTasks
        public ActionResult Tasks(String id)
        {
            ViewBag.Title = "Tasks Page";

            var listOfTasks = new Api_ChecklistTasksController().GetChecklistTaskRecords(id);

            return View(listOfTasks);
        }
    }
}