using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISkillService
    {
        IQueryable<Skill> GetAll();
        Skill Add(Skill skill);
        bool Delete(int id);
        Skill Update(Skill skill);
    }
}
