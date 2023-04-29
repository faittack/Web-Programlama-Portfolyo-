using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class LoginController : Controller
    {
      
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
          Account clsAuth= new Account();  
            
            if(clsAuth.UserLoginControll(username,password))
            {
                HttpContext.Session.SetString("UserSession", "1");
                return RedirectToAction("MainPage", "Home");
            }
            else
            {

                ViewBag.Mesaj = clsAuth.ErrorMesaj;
                return View();

            }
                 
        }

    }
}
