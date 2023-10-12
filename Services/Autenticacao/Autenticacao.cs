using Data.Unit;
using Models;






namespace Services.Autenticacao
{
	public class Autenticacao 
	{
        public IUnitOfWork _db { get; set; }

        public string path = Environment.CurrentDirectory + @"\Usuario\UsuarioLogado.txt";
        

        
        public Autenticacao(IUnitOfWork db)
        {
            _db = db;
        }




        public Account? LoggingUser(string email, string password)
		{
            try
            {
                Account conta = _db.Account.Logging(email, password);
                SavingUser(conta);
                return conta;
            }
            catch (System.NullReferenceException)
            {
                return null;
            }

        }

        public void SavingUser(Account user)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(user.Id.ToString());
            sw.Close();
        }

        public void ErasingUser()
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("");
            sw.Close();
        }

        public Account GettingUser()
        {
            StreamReader sr = new StreamReader(path);
            int id = int.Parse(sr.ReadLine());
            sr.Close();
            return _db.Account.GetById(c => c.Id == id);
        }

	}
}
