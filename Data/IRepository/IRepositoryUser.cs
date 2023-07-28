using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepository
{
    public interface IRepositoryUser<T>
    {
        public T GetById(Expression<Func<T, bool>> filter);
        public IEnumerable<T> GetAll();
    }
}
