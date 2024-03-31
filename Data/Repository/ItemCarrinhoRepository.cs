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
    public class ItemCarrinhoRepository : Repository<ItemCarrinho>, IItemCarrinhoRepository
    {
        public AppDbContext _db;
        public ItemCarrinhoRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public ItemCarrinho AdicionarAoCarrinho(Account conta, Produto prod)
        {
            ItemCarrinho itemCarrinho = new ItemCarrinho()
            {
                UsuarioId = conta.Id,
                ProdutoId = prod.Id
            };
            _db.ItemCarrinho.Add(itemCarrinho);
            _db.SaveChanges();
            return itemCarrinho;
        }

        public IList<ItemCarrinho> RetornarTodosOsItemsDoCarrinho(Account conta)
        {
            IList<ItemCarrinho> itemCarrinhos = _db.ItemCarrinho.Where(c=> c.UsuarioId == conta.Id).ToList();
            return itemCarrinhos;
        }

        public ItemCarrinho ComprarProduto(Account conta, Produto prod)
        {
            throw new NotImplementedException();
        }


    }
}
