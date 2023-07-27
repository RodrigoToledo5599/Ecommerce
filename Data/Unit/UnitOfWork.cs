using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IRepository;
using Data.Repository;

namespace Data.Unit
{
    public class UnitOfWork : IUnitOfWork
    {
        public AppDbContext _db;
        public IProdutoRepository Produto { get; private set; }
        public ICategoryRepository Category { get; private set; }

        public UnitOfWork(AppDbContext db)
        {
            _db = db;
            Produto = new ProdutoRepository(_db);
            Category = new CategoryRepository(_db);

        }

    }
}
