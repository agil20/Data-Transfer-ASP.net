using DATA_transfer.Models;
using DATA_transfer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DATA_transfer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Aqil";
            ViewData["Surname"] = "Xalilov";
            TempData["Age"] = 20;
            //  return RedirectToAction("About");
            List<Student> students = new List<Student> {
               new Student{Id=1,Name="Sahil"},
               new Student{Id=2,Name="Aqil"}

           };
            List<Group> groups = new List<Group> {
               new Group{Id=1,Name="P322"},
               new Group{Id=2,Name="P323"}

           };
            HomeVm home=new HomeVm();
            home.Groups= groups;
            home.students = students;
            // ViewBag.Students=students;
            return View(home);
        }
        public IActionResult About()
        {
            return View();
        }
    }
    
}
