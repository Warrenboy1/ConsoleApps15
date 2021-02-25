using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApps.Models;
using ConsoleAppProject.App02;

namespace WebApps.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DistanceConverter()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BMICalculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BMICalculator(BMI bmi)
        {
            if (bmi.Metres > 140)
            {
                bmi.BMICalculateMetric();
            }
            else if (bmi.Feet > 4 && bmi.Stones > 6)
            {
                bmi.BMICalculateImperial();
            }
            else
            {
                ViewBag.Error = "You have entered values too small for an adult >_>";
               return View();
            } 

            double bmiResult = bmi.BMIResult;

            return RedirectToAction("HealthMessage", new { bmiResult });
        }
        public IActionResult HealthMessage(double bmiResult)
        {
            return View(bmiResult);
        }
        public IActionResult StudentMarks()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
