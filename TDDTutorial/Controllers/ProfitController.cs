using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDDTutorial.Data;

namespace TDDTutorial.Controllers
{
    public class ProfitController : Controller
    {
        // GET: Profit
        public ActionResult Index()
        {
            return View(DataContext.GetSprints());
        }
    }
}