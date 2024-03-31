using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IRepository;

namespace Data.Unit
{
    public interface IUnitOfWork 
    {
        IProdutoRepository Produto { get; }
        ICategoryRepository Category { get; }
        IAccountRepository Account { get; }
        IFavoritosRepository Favoritos { get; }
        IItemCarrinhoRepository ItemCarrinho { get; }



    }
}
