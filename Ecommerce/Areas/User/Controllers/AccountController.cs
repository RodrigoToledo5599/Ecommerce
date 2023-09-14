using Microsoft.AspNetCore.Mvc;

namespace EcommerceWeb.Areas.User.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
