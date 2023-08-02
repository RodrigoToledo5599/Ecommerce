using Data.Unit;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.ViewModels;

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
            List<ProdutoVM> prods = new List<ProdutoVM>();

            foreach(Produto prod in produtos)
            {
                ProdutoVM prodvm = new ProdutoVM(prod);
                prods.Add(prodvm);
            }
            
            return View(prods);
        }

        #endregion

        #region Details
        public IActionResult Details(int id)
        {

            Produto produto = _db.Produto.GetById(c => c.Id == id);
            ProdutoVM prodvm = new ProdutoVM(produto);
            Category Categoria = _db.Category.GetById(c => c.Id == produto.CategoriaId);
            ViewData["Categoria"] = Categoria.Name;
            return View(prodvm);
        }
        #endregion
    }
}
