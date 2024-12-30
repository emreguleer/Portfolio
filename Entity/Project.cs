using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string GitHubLink { get; set; }
        public string? SiteLink { get; set; }
        public string Description { get; set; }
        public string? Photo {  get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}
