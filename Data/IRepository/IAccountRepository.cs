using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Data.IRepository
{
    public interface IAccountRepository : IRepository<Account>
    {
        Account Logging(string email,string senha);
    }
}
