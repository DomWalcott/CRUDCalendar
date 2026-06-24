using Microsoft.AspNetCore.Mvc;

namespace CRUDCalendar.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
