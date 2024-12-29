using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Shared.Abstract
{
    public interface IRepository<T> where T : class
    {
        T Add(T entity);
        T Update(T entity);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
        bool Delete(int id);
        bool HardDelete(int id);
        T GetById(int id);
        T GetFirstOrDefault(Expression<Func<T, bool>> predicate);
        void Save();
    }
}
