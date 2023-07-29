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
    public class ProdutoRepositoryUser : RepositoryUser<Produto>, IProdutoRepositoryUser
    {
        public AppDbContext _db;
        public ProdutoRepositoryUser(AppDbContext db) : base(db)
        {
            _db = db;
        }

    
    }
}
