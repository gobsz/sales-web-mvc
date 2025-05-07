using Microsoft.AspNetCore.Mvc;
using sales_web_mvc.Models;

namespace sales_web_mvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> List = [];
            List.Add(new Department { Id = 1, Name = "Eletronics" });
            List.Add(new Department { Id = 2, Name = "Fashion" });

            return View(List);
        }
    }
}