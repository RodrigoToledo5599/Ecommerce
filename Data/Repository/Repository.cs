﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Data.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private AppDbContext _db;
        public Repository(AppDbContext db)
        {
            _db = db;
        }

        void IRepository<T>.Delete(T entity)
        {
            _db.Set<T>().Remove(entity);
            _db.SaveChanges();
        }

        T IRepository<T>.Edit(T entity)
        {
            _db.Set<T>().Update(entity);
            _db.SaveChanges();
            return entity;
        }

        IList<T> IRepository<T>.GetAll()
        {
            IList<T> list =_db.Set<T>().ToList();
            return list;

        }

        T IRepository<T>.GetById(Expression<Func<T, bool>> filter)
        {
            T register = _db.Set<T>().FirstOrDefault(filter);
            return register;
        }

        T IRepository<T>.Insert(T entity)
        {
            _db.Add(entity);
            _db.SaveChanges();
            return entity;
        }
    }
}
