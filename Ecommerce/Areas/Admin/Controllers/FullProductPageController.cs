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


        #region Index/Details
        public IActionResult Index(int id)
        {
            Produto produto = _db.Produto.GetById(c => c.Id == id); 
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

        #region Insert

        public IActionResult Add() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Produto produto)
        {
            _db.Produto.Insert(produto);
            return View();
        }

        #endregion

        #region Delete

        public IActionResult Delete(int id)
        {
            Produto produto = _db.Produto.GetById(c => c.Id == id);
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
