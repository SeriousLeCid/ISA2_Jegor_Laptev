using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstMVC.Models;

namespace MyFirstMVC.Controllers
{
    public class TestController : Controller
    {
        public string GetString()
        {
            return "Hello World!";
        }

        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Jegor";
            emp.LastName = "Laptev";
            emp.Solary = 5000;

            ViewData["Employee"] = emp;
            return View("MyView");
        }
    }
}