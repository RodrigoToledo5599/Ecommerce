 using Microsoft.AspNetCore.Mvc;

namespace EcommerceWeb.Areas.User.Controllers
{
	[Area("User")]
	public class AccountController : Controller
	{
		public IActionResult CrieSuaConta()
		{
			return View();
		}







	}
}
