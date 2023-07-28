using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IRepository;
using Models;

namespace Data.Repository
{
    public class ProdutoRepositoryUser : RepositoryUser<Produto>, IProdutoRepositoryUser
    {
        public AppDbContext _db { get; set; }
        public ProdutoRepositoryUser(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
