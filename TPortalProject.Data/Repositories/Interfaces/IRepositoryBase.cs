using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace TPortalProject.Data.Repositories.Interfaces
{
    public interface IRepositoryBase<T> : IDisposable where T : class
    {
        List<T> List();

        T Get(int id);

        IQueryable<T> GetQuery(int id);

        IQueryable<T> GetQuery(Expression<Func<T, bool>> predicate);

        T Find(Expression<Func<T, bool>> predicate);

        T Find(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, object> includes );

        T Create(T info);

        int Insert(T info);

        void Update(T info);

        void Delete(T info);

        void Delete(int id);

        int Count(Expression<Func<T, bool>> predicate);
    }
}
