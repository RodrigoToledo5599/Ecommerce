using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Unit;
using Models;
using Services.Autenticacao;

namespace ModelsDTO.DTO.MainPageControllerDTO
{
	public class InsertDTO : AccountDTO
	{
        private readonly IUnitOfWork _db;

        public Produto? produto;
        public InsertDTO(IUnitOfWork db)
        {
            _db = db;
        }

        public void GetAccount()
        {
            conta = new Autenticacao(_db).GettingUser();
        }

        



    }
}
