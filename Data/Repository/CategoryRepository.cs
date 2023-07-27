using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IRepository;
using Models;

namespace Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public AppDbContext _db;
        public CategoryRepository (AppDbContext db) : base (db)
        {
            _db = db;
        }
    }
}
