using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Todo.Services;
using Todo.Web.Models;

namespace Todo.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegistrationModel model)
        {
            if(!ModelState.IsValid || !model.Password.Equals(model.ConfirmPassword))
            {
                throw new HttpRequestValidationException("model is invalid");
            }

            var loggedId = authService.Register(model.Username, model.Password);

            if (loggedId != null)
            {
                FormsAuthentication.SetAuthCookie(loggedId.ToString(), true);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", ""), new { });
            }
            return View();
        }
    }
}