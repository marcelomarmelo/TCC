using Microsoft.AspNetCore.Mvc;
using TCC.Models;

namespace TCC.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Logar(LoginModel dados)
        {
            LoginModel model = new LoginModel();
            model.Login = "carlosalberto@gmail.com";
            model.Senha = "Gostavatantodevc";
            return View(model);
        }
    }
}
