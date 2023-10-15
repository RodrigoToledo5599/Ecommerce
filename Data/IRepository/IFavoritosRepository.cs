using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Data.IRepository
{
    public interface IFavoritosRepository : IRepository<Favoritos>
    {
        IEnumerable<Favoritos> GetAllWithFilter(Account conta ,Expression<Func<Favoritos, bool>> filter);
        Favoritos InsertAFavorite(Account conta,Produto prod);
        Favoritos? FindFavoriteRegister(Account conta, Produto produto);

	}
}
