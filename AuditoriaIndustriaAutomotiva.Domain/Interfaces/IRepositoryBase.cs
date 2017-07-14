using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AuditoriaIndustriaAutomotiva.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(int total);
        IEnumerable<TEntity> GetAllNoTracking();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
