using Business.Abstract;
using Entity;
using Microsoft.EntityFrameworkCore;
using Repository.Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProjectService : IProjectService
    {
        private readonly IRepository<Project> _repository;
        private readonly ISkillService _skillService;

        public ProjectService(IRepository<Project> repository, ISkillService skillService)
        {
            _repository = repository;
            _skillService = skillService;
        }

        public  Project Add(Project project, List<int> skillIds)
        {
            var addedProject = _repository.Add(project);
            if(skillIds != null && skillIds.Count > 0)
            {
                var skills = _skillService.GetAll(s => skillIds.Contains(s.Id)).ToList();
                addedProject.Skills = skills;
                _repository.Update(addedProject);
            }
            return addedProject;
        }
        public List<Project> GetAllMission()
        {
            return _repository.GetAll()
                .Include(x => x.Skills)
                .Select(x => new Project
                {
                    Id = x.Id,
                    Title = x.Title,
                    GitHubLink = x.GitHubLink,
                    SiteLink = x.SiteLink,
                    Description = x.Description,
                    Photo = x.Photo,
                    Skills = x.Skills.ToList(),
                })
                .ToList();
        }
        public bool UpdateSkill(int projectId, List<int> skillIds)
        {

            var project = _repository.GetAll().FirstOrDefault(m => m.Id == projectId);

            if (project != null)
            {
                var skills = _skillService.GetAll(s => skillIds.Contains(s.Id)).ToList();
                project.Skills = skills;
                _repository.Update(project);

                return true;
            }

            return false;
        }
    }
}
