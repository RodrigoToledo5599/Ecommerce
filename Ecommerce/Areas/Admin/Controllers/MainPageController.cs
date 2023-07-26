using Data;
using Data.Unit;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EcommerceWeb.Areas.Admin.Controllers
{
    [BindProperties]
    public class MainPageController : Controller
    {
        public IUnitOfWork _db { get; set; }
        public MainPageController (IUnitOfWork db)
        {
            _db = db;
        }



        public IActionResult Index()
        {
            var produtos = _db.Produto.GetAll();
            return View(produtos);
        }




    }
}
