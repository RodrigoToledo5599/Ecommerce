using Data.Unit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using ModelsDTO.DTO.MainPageControllerDTO;
using Services.Autenticacao;

namespace EcommerceWeb.Areas.User.Controllers
{
    [Area("User")]
    //[BindProperties]
    public class MainPageController : Controller
    {
        public IUnitOfWork _db { get; set; }

        public MainPageController(IUnitOfWork db)
        {
            _db = db; 
        }


        #region Index
        public IActionResult Index()
        {
            var FinalModel = new MainPageDTO();
            Account? user = new Autenticacao(_db).GettingUser();

            if(user == null)
            {
                FinalModel.conta = null;
            }
            else
            {
                FinalModel.conta = user;
            }

            FinalModel.produto = _db.Produto.GetAll();


            return View(FinalModel);
        }

        #endregion

        #region Insert

        
        public IActionResult Insert(string id)
        {   

            InsertDTO insertdto = new InsertDTO(_db);
            insertdto.GetAccount();

            IEnumerable<SelectListItem> categories = _db.Category.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString(),
            });
            ViewBag.Categories = categories;


            return View();
        }

        [HttpPost]
        public IActionResult Insert(InsertDTO insertDto)
        {

            Produto? produto = insertDto.produto;
            _db.Produto.Insert(produto);
            return View();
            
        }

        #endregion

        #region Details
        public IActionResult Details(int id)
        {

            Produto prod = _db.Produto.GetById(c => c.Id == id);
            DetailsDTO model = new DetailsDTO(_db)
            { 
                produto = prod
            };

            model.ScriptZao();
            
            return View(model);
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
