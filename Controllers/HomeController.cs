using Microsoft.AspNetCore.Mvc;
using ThalesDotNetTest.Models;
using ThalesDotNetTest.Models.DAL;

namespace ThalesDotNetTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
