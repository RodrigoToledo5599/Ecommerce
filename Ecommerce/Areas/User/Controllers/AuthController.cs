using Data.Unit;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services.Autenticacao;

namespace EcommerceWeb.Areas.User.Controllers
{
	[Area("User")]
	public class AuthController : Controller
    {
        private readonly IUnitOfWork _db;
        public AuthController(IUnitOfWork db)
        {
            _db = db;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email= "ADM@gmail.com", string senha= "adm123")
        {
            Account? account = new Autenticacao(_db).LoggingUser(email, senha);

            if (account == null)
                return NotFound();
            else
                return Redirect($"User/MainPage/Index");


        }

    }
}
