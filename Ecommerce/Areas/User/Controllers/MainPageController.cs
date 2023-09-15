using Data;
using Data.Unit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using Models.DTO;
using Models.DTO.MainPageControllerDTO;

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
        public IActionResult Index(string? id)
        {
            var FinalModel = new MainPageDTO();
            if(id == null)
            {
                FinalModel.conta = null;
            }
            else
            {
                FinalModel.conta = _db.Account.GetById(c => c.Id == int.Parse(id));
            }

            FinalModel.produto = _db.Produto.GetAll();


            return View(FinalModel);
        }

        #endregion

        #region Insert

        public IActionResult Insert()
        {   

            IEnumerable<SelectListItem> categories = _db.Category.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString(),
            });
            ViewBag.Categories = categories;
            
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
        /* public IActionResult Details(int id)
        {

            ProdutoDTO produtoVm = new ProdutoDTO
            { produto = _db.Produto.GetById(c => c.Id == id)  };
            produtoVm.category = _db.Category.GetById(c => c.Id == produtoVm.produto.CategoriaId);
            
            return View(produtoVm);
        }*/
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
