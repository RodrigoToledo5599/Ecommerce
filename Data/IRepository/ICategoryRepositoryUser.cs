using System.Linq.Expressions;
using Models;

namespace Data.IRepository
{
    public interface ICategoryRepositoryUser: IRepositoryUser<Category>
    {
        Category FindCategoryById(Expression<Func<Category, bool>> filter); 

    }
    
    
}
