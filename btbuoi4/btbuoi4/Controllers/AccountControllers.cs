using btbuoi4.Models;
using Microsoft.AspNetCore.Mvc;


namespace YourNamespace.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Đăng ký thành công!";
                return View(user);
            }
            
            return View(user);
        }
    }
}