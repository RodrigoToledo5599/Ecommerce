using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepository
{
    public interface IRepository<T>
    {
        public T GetById(Expression<Func<T, bool>> filter);
        public IList<T> GetAll();
        public T Edit (T entity);
        public T Insert (T entity);
        public void Delete (T entity);
        
    }
}
