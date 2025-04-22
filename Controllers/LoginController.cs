using Microsoft.AspNetCore.Mvc;

namespace MYcicdApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
