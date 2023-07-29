using Data.Unit;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EcommerceWeb.Areas.User.Controllers
{
    [Area("User")]
    public class ProductsController : Controller
    {
        //[BindProperties]
        public IUnitOfWorkUser _db { get; set; }
        public ProductsController(IUnitOfWorkUser db)
        {
            _db = db;
        }

        #region Index
        public IActionResult Index()
        {
            var produtos = _db.Produto.GetAll();
            return View(produtos);
        }

        #endregion

        #region Details
        public IActionResult Index(int id)
        {

            Produto produto = _db.Produto.GetById(c => c.Id == id);
            Category Categoria = _db.Category.GetById(c => c.Id == produto.CategoriaId);
            ViewData["Categoria"] = Categoria.Name;
            return View(produto);
        }
        #endregion
    }
}
