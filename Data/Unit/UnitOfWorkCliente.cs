﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Unit
{
    public class UnitOfWorkCliente
    {
        private AppDbContext _db;

        public UnitOfWorkCliente(AppDbContext db)
        {
            _db = db;
        }


    }
}
