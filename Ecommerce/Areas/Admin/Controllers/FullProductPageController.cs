using Data;
using Data.IRepository;
using Data.Repository;
using Data.Unit;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EcommerceWeb.Areas.Admin.Controllers
{
    [BindProperties]
    public class FullProductPageController : Controller
    {
        public IUnitOfWork _db { get; set; }
        public FullProductPageController (IUnitOfWork db)
        {
            _db = db;
        }

        public IActionResult Index(int id)
        {
            Produto produto = _db.Produto.GetById(c => c.Id == id); 
            return View(produto);
        }



    }
}
