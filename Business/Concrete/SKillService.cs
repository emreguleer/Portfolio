using Business.Abstract;
using Entity;
using Repository.Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SkillService : ISkillService
    {
        private readonly IRepository<Skill> _repository;

        public SkillService(IRepository<Skill> repository)
        {
            _repository = repository;
        }

        public Skill Add(Skill skill)
        {
            return _repository.Add(skill);
        }

        public bool Delete(int id)
        {
            return _repository.HardDelete(id);
        }

        public IQueryable<Skill> GetAll()
        {
            return _repository.GetAll();
        }

        public Skill Update(Skill skill)
        {
            return _repository.Update(skill);
        }
    }
}
