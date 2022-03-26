using Microsoft.AspNetCore.Mvc;

namespace ContactControl.Controllers
{
    public class Contact : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
