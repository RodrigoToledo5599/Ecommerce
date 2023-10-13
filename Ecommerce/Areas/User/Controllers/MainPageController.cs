using AutoMapper;
using Data.Unit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using ModelsDTO.DTO.MainPageControllerDTO;
using Services.Autenticacao;
using Services.Favorites;

namespace EcommerceWeb.Areas.User.Controllers
{
    [Area("User")]
    //[BindProperties]
    public class MainPageController : Controller
    {
        public IUnitOfWork _db;
        private readonly IMapper _mapper;


		public MainPageController(IUnitOfWork db,IMapper mapper)
        {
            _db = db; 
            _mapper = mapper;
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
        public IActionResult Insert(Produto prod)
        {
            Account conta = new Autenticacao(_db).GettingUser();
            if (conta.Role != Models.Enums.Roles.Administrator)
                return RedirectToAction("Index");
            
            else if (prod == null)
                return View();

            else
            {
                _mapper.Map<ProdutoDTO>(prod);
                prod.Id = 0; 
				_db.Produto.Insert(prod);
                return RedirectToAction("Index");
            }
			// o entity framework estava lançando um valor default de 1 para o Id mesmo com o IDENTITY_INSERT Produto ON no sql
			//entao a solução é manualmente mudar o ID para 0 que fará com que o SQL lide com o valor do Id sozinho (simples auto increment no caso).
		}

		#endregion

		#region Details
		public IActionResult Details(int id)
        {
            Produto prod = new Produto();
            prod = _db.Produto.GetById(c => c.Id == id);
            DetailsDTO model = new DetailsDTO(_db)
            { 
                produto = prod
            };
            model.AccountAndCategory();
            return View(model);
        }
        #endregion

        #region Edit
        public IActionResult Edit(int id)
        {
            Account conta = new Autenticacao(_db).GettingUser();
            if(conta.Role != Models.Enums.Roles.Administrator)
            {
                return RedirectToAction("Index");
            }


            string? categoria;
            var produto = _db.Produto.GetById(c => c.Id == id);
            if (produto.CategoriaId == null)
                categoria = "Sem Categoria";
            else
                categoria = _db.Category.GetById(c => c.Id == produto.CategoriaId).Name;


            IEnumerable<SelectListItem> categories = _db.Category.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString(),
            });

            ViewBag.Categories = categories;
            ViewData["categoria"] = categoria;
            return View(produto);
        }

        [HttpPost]
        public IActionResult Edit(Produto produto)
        {
            Account conta = new Autenticacao(_db).GettingUser();
            if (conta.Role != Models.Enums.Roles.Administrator)
                return RedirectToAction("Index");
            else
            {
                _db.Produto.Edit(produto);
                return RedirectToAction("Index");
            }
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
            Account conta = new Autenticacao(_db).GettingUser();
            if (conta.Role != Models.Enums.Roles.Administrator)
            {
                return RedirectToAction("Index");
            }
            _db.Produto.Delete(produto);
            return RedirectToAction("Index");
        }

        #endregion

        #region FavoritosRegion
        /*
        [HttpPost]
        public IActionResult AddFavorito(int idItem)
        {
            Account conta = new Autenticacao(_db).GettingUser();
            Produto prod = _db.Produto.GetById(c => c.Id == idItem);
            FavoritosFunctionalities favs = new FavoritosFunctionalities(_db,conta);
            var favoritos = favs.ListandoOsFavoritos();
            bool isFav = favs.CheckIfProductIsFavorite(prod);
            if (isFav is true)
            {
                _db.Favoritos.InsertAFavorite(conta, prod);
                return Ok("Produto adicionado a lista de favoritos");
            }
            else
                return Ok();



        }
        */
        













        #endregion
    }

}
