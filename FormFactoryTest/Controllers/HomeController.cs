using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormFactoryTest.Models;
using FormFactoryTest.Models.Create;

namespace FormFactoryTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var example = new NestedFormsExample2();
            return View(example);
        }

        [HttpPost]
        public IActionResult Save(NestedFormsExample2 model)
        {
            var test = model;
            return Ok();
        }
        
        public IActionResult MyForm()
        {
            var myform = new CreateSurveyViewModel();
            return View(myform);
        }

        [HttpPost]
        public IActionResult SaveMyForm(CreateSurveyViewModel model)
        {
            var test = model;
            return Ok();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}