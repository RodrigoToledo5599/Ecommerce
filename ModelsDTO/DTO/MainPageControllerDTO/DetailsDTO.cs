using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Unit;
using Models;
using Services.Autenticacao;

namespace ModelsDTO.DTO.MainPageControllerDTO
{
    public class DetailsDTO : AccountDTO
    {
        private readonly IUnitOfWork _db;
        public DetailsDTO(IUnitOfWork db)
        {
            _db = db;
        }
        public Produto produto { get; set; }
        public string? categoria { get; set; }


        public void GetCategoryName()
        {
            int? ID = produto.CategoriaId;
            Category category = new Category();
            if (ID != null )
            {
                category = _db.Category.GetById(c => c.Id == ID);
                categoria = category.Name;
            }
            else
            {
                categoria = "Sem Categoria";
            }
        }


        public void GetAccount()
        {
            conta = new Autenticacao(_db).GettingUser();
        }

        public void ScriptZao()
        {
            GetAccount();
            GetCategoryName();
        }
        
    }
}
