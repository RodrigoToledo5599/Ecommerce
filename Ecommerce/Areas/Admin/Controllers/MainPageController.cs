using Data;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EcommerceWeb.Areas.Admin.Controllers
{
    [BindProperties]
    public class MainPageController : Controller
    {
        public AppDbContext _db { get; set; }
        public MainPageController (AppDbContext db)
        {
            _db = db;
        }



        public IActionResult Index()
        {
            List<Produto> produtos = _db.Produto.ToList();
            return View(produtos);
        }




    }
}
