using Data;
using Data.Unit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using Models.ViewModels;

namespace EcommerceWeb.Areas.User.Controllers
{
    [Area("User")]
    //[BindProperties]
    public class MainPageController : Controller
    {
        public IUnitOfWork _db { get; set; }
        public MainPageController (IUnitOfWork db) 
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

        #region Insert

        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _db.Produto.Insert(produto);
                return RedirectToAction("Index");
            }
            else
            {
                
                return View();
            }

        }

        #endregion

        #region Details
        public IActionResult Details(int id)
        {

            ProdutoVM produtoVm = new ProdutoVM
            { produto = _db.Produto.GetById(c => c.Id == id)  };
            produtoVm.category = _db.Category.GetById(c => c.Id == produtoVm.produto.CategoriaId);
            
            return View(produtoVm);
        }
        #endregion

        #region Edit
        public IActionResult Edit(int id)
        {
            string? categoria;
            var produto = _db.Produto.GetById(c => c.Id == id);
            if (produto.CategoriaId == null)
                categoria = "N/A";
            else
                categoria = _db.Category.GetById(c => c.Id == produto.CategoriaId).Name;

            ViewData["categoria"] = categoria;
            return View(produto);
        }

        [HttpPost]
        public IActionResult Edit(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _db.Produto.Edit(produto);
            }
            return View(produto);
            
        }

        #endregion

        #region Delete


        public IActionResult Delete(int id)
        {
            var produto =_db.Produto.GetById(c => c.Id == id);
            return View(produto);
        }

        [HttpPost]
        public IActionResult Delete(Produto produto)
        {
            _db.Produto.Delete(produto);
            return RedirectToAction("Index");
        }

        #endregion


    }

}
