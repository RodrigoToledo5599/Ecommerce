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
    public class AccountRepository :Repository<Account>, IAccountRepository
    {
        public AppDbContext _db { get; }
        public AccountRepository(AppDbContext db) : base(db) 
        {
            _db = db;
        }

		public Account Logging(string email,string senha)
		{
			Account? account = _db.Set<Account>().Where(c => c.Email == email && c.Senha == senha).FirstOrDefault();    
            return account;
		}
	}
}
