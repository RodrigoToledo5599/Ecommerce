using Data;
using Data.Unit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;

namespace EcommerceWeb.Areas.Admin.Controllers
{
    //[Area("Admin")]
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
            /*IEnumerable<SelectListItem> ListaDeCategoria = _db.Category.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString(),
            });
            
            ViewBag.ListaDeCategoria = ListaDeCategoria;
            */
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
            _db.Produto.Insert(produto);
            return View();
        }

        #endregion

    }
}
