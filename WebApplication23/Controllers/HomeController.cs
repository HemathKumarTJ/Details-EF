using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication23.Models;


namespace WebApplication23.Controllers
{
    public class HomeController : Controller
    {
       
        TaskContext _taskContext;
        public HomeController( TaskContext taskContext)
        {
          
            _taskContext= taskContext;
        }

       
        public IActionResult First()
        {
            return View();
        }

        public IActionResult Next(Details details)
        {
            Details hk= new Details();
            hk.Id = details.Id;
            hk.Name=details.Name;
            hk.Age=details.Age;
            hk.Salary=details.Salary;
            _taskContext.Add(hk);
            _taskContext.SaveChanges();

            return RedirectToAction("First");
        }

       
    }
}