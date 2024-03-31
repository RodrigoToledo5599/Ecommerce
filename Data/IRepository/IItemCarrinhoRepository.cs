using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Data.IRepository
{
    public interface IItemCarrinhoRepository : IRepository<ItemCarrinho>
    {
        ItemCarrinho AdicionarAoCarrinho(Account conta, Produto prod);
        ItemCarrinho ComprarProduto(Account conta, Produto prod);

    }
}
