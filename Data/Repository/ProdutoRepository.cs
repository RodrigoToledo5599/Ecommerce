using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IRepository;
using Models;

namespace Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public AppDbContext _db;
        public ProdutoRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
