using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Shared.Abstract
{
    public interface IService<T> where T : class
    {
        T Add(T entity);
        T Update(T entity);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
        T GetById(int id);
        bool HardDelete(int id);
    }
}
