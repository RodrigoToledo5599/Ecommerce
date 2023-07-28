using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Data.IRepository;

namespace Data.Repository
{
    public class RepositoryUser<T> : IRepositoryUser<T> where T : class
    {
        protected AppDbContext _db { get; set; }

        public RepositoryUser(AppDbContext db)
        {
            _db = db;
        }

        IEnumerable<T> IRepositoryUser<T>.GetAll()
        {
            IEnumerable<T> list = _db.Set<T>().ToList();
            return list;

        }

        T IRepositoryUser<T>.GetById(Expression<Func<T, bool>> filter)
        {
            T register = _db.Set<T>().FirstOrDefault(filter);
            return register;
        }
    }
}
