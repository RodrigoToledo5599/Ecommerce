using Data.Unit;
using Models;

namespace EcommerceWeb.Services
{
    public class Autenticacao
    {
        private readonly IUnitOfWork _db;
        public Autenticacao(IUnitOfWork db)
        {
            _db = db;
        }
        public Account? Autenticar(string email, string senha)
        {
            try
            {
                Account account = _db.Account.Logging(email, senha);
                return account;
            }
            catch(System.NullReferenceException)
            {
                return null;
            }
            

        }

    }
}
