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
    public class CategoryRepositoryUser : RepositoryUser<Category>, ICategoryRepositoryUser
    {
        public AppDbContext _db { get; set; }
        public CategoryRepositoryUser(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public Category FindCategoryById(Expression<Func<Category, bool>> filter)
        {
            Category categoria = _db.Set<Category>().FirstOrDefault(filter);
            return categoria;
        }
    }
}
