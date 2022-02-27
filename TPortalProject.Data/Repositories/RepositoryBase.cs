using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TPortalProject.Data.Context;
using TPortalProject.Data.Repositories.Interfaces;

namespace TPortalProject.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly TPortalProjectContext _context;
        protected DbSet<T> DbSet
        {
            get
            {
                return _context.Set<T>();
            }
        }

        public RepositoryBase(TPortalProjectContext context)
        {
            _context = context;
        }

        public List<T> List()
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }
        public IQueryable<T> GetQuery(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetQuery(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return DbSet.Where(predicate);
            }
            catch(Exception)
            {
                throw;
            }            
        }

        public void Update(T info)
        {
            throw new NotImplementedException();
        }

        public void Delete(T info)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T Create(T info)
        {
            throw new NotImplementedException();
        }

        public int Insert(T info)
        {
            throw new NotImplementedException();
        }
    }

}
