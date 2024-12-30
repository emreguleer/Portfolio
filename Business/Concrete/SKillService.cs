using Business.Abstract;
using Business.Shared.Concrete;
using Entity;
using Repository.Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SkillService : Service<Skill>, ISkillService
    {
        private readonly IRepository<Skill> _repository;

        public SkillService(IRepository<Skill> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
