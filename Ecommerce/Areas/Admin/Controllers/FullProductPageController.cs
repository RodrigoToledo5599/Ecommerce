using Data;
using Data.IRepository;
using Data.Repository;
using Data.Unit;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EcommerceWeb.Areas.Admin.Controllers
{
    //[BindProperties]
    [Area("Admin")]
    public class FullProductPageController : Controller
    {
        public IUnitOfWork _db { get; set; }
        public FullProductPageController (IUnitOfWork db)
        {
            _db = db;
        }


        #region Index/Details
        public IActionResult Index(int id)
        {

            Produto produto = _db.Produto.GetById(c => c.Id == id);
            Category Categoria = _db.Category.GetById(c=>c.Id == produto.CategoriaId);
            ViewData["Categoria"] = Categoria.Name; 
            return View(produto);
        }
        #endregion

        #region Edit
        public IActionResult Edit(int id)
        {
            var produto = _db.Produto.GetById(c => c.Id == id);
            return View(produto);
        }

        [HttpPost]
        public IActionResult Edit(Produto produto) 
        {
            _db.Produto.Edit(produto);
            return View(produto);
        }

        #endregion

        #region Delete




        [HttpPost]
        public IActionResult Delete(Produto produto)
        {
            _db.Produto.Delete(produto);
            return RedirectToAction("Admin/MainPage/Index");
        }

        #endregion
    }
}
