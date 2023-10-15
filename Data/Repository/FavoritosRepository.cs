using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Data.IRepository;
using Models;

namespace Data.Repository
{
    public class FavoritosRepository : Repository<Favoritos>, IFavoritosRepository
    {
        public AppDbContext _db;
        public FavoritosRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<Favoritos> GetAllWithFilter(Account conta ,Expression<Func<Favoritos, bool>> filter)
        {
            var favoritos = _db.Favoritos.Where(filter).ToList();
            return favoritos;
        }

        public Favoritos InsertAFavorite(Account conta, Produto prod)
        {
            Favoritos favorito = new Favoritos()
            {
                UsuarioId = conta.Id,
                ProdutoId = prod.Id,
            };
            _db.Favoritos.Add(favorito);
            _db.SaveChanges();
            return favorito;
        }

        public Favoritos? FindFavoriteRegister(Account conta, Produto prod)
        {
            Favoritos? favorito = _db.Favoritos.FirstOrDefault(c => c.UsuarioId == conta.Id && c.ProdutoId == prod.Id );
            return favorito;
		}
    }
}
