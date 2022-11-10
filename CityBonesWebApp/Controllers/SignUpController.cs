using Microsoft.AspNetCore.Mvc;

namespace CityBonesWebApp.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
