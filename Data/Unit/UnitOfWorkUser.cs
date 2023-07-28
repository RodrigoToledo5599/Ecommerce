using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IRepository;
using Data.Repository;

namespace Data.Unit
{
    public class UnitOfWorkUser : IUnitOfWorkUser
    {
        public AppDbContext _db;
        public IProdutoRepositoryUser Produto { get; set; }

        public UnitOfWorkUser(AppDbContext db)
        {
            _db = db;
            Produto = new ProdutoRepositoryUser(_db);
        }


    }
}
