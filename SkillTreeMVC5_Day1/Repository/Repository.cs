﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace SkillTreeMVC5_Day1.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public IUnitOfWork UnitOfWork { get; set; }
        private DbSet<T> _objectSet;
        private DbSet<T> ObjectSet => _objectSet ?? (_objectSet = UnitOfWork.Context.Set<T>());

        public Repository(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public Repository()
        {
        }

        public IQueryable<T> LookupAll()
        {
            return ObjectSet;
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> filter)
        {
            return ObjectSet.Where(filter);
        }

        public T GetSingle(Expression<Func<T, bool>> filter)
        {
            return ObjectSet.SingleOrDefault(filter);
        }

        public void Create(T entity)
        {
            ObjectSet.Add(entity);
        }

        public void Remove(T entity)
        {
            ObjectSet.Remove(entity);
        }

    }
}