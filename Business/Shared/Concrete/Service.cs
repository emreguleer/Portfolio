using Business.Shared.Abstract;
using Repository.Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Shared.Concrete
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _repo;

        public Service(IRepository<T> repo)
        {
            _repo = repo;
        }

        public T Add(T entity)
        {
            return _repo.Add(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _repo.GetAll();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return _repo.GetAll(predicate);
        }


        public T GetById(int id)
        {
            return _repo.GetById(id);
        }


        public bool HardDelete(int id)
        {
            return _repo.HardDelete(id);
        }

        public T Update(T entity)
        {
            return _repo.Update(entity);
        }
    }
}
