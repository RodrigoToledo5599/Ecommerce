using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IRepository;

namespace Data.Unit
{
    public interface IUnitOfWorkUser
    {
        IProdutoRepositoryUser Produto { get; }
    }
}
