using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Web.Mvc;

using Microsoft.VisualBasic;

namespace Cricketdata.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet]
        public ActionResult Index()
        {
            var model = new CricketViewModel();
            return View(model);
        }

        [HttpPost]
        
        public ActionResult Index(CricketViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.InsertCricket();
                    TempData["Message"] = "Cricket data inserted successfully."; // Use TempData for success message
                    return RedirectToAction("About");
                }
                catch (Exception ex)
                {
                    ViewBag.Error = $"Error inserting cricket player: {ex.Message}";
                    // Log the exception if needed for further investigation
                }
            }

            // If ModelState is not valid or insertion fails, return to the Index view with the model
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}