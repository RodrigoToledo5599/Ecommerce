using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Unit;
using Models;

namespace Services.Favorites
{
    public class FavoritosFunctionalities
    {
        public IUnitOfWork _db;
        public Account _conta;
        
        public FavoritosFunctionalities(IUnitOfWork db, Account conta) 
        {
            _db = db;
            _conta = conta;
        }


        public bool CheckIfProductIsFavorite(Produto product)
        {
            bool IsFavorite = false;
            var favs = ListandoOsFavoritos();
            foreach(var prod in favs)
            {
                if(prod.ProdutoId == product.Id)
                {
                    IsFavorite = true;
                    break;
                }
            }
            return IsFavorite;
        }
        
        public IEnumerable<Favoritos> ListandoOsFavoritos()
        {
            return _db.Favoritos.GetAllWithFilter(_conta,c => c.UsuarioId == _conta.Id);
        }

    }
}
