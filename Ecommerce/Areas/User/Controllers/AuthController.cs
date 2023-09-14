using Data.Unit;
using EcommerceWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Models;

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
        public IActionResult Login(string email, string senha)
        {
            Account? account = new Autenticacao(_db).Autenticar(email, senha);

            if (account == null)
                return NotFound();
            else
                return Redirect($"User/MainPage/Index/{account.Id}");


        }

    }
}
