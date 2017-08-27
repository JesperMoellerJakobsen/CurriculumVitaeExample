using System.Collections.Generic;
using CurriculumVitae.DomainModels.Specifications;

namespace CurriculumVitae.DomainModels.Users
{
    public class DetailedUser
    {
        public User User { get; set; }
        public List<WorkExperience> WorkExperiences { get; set; }
        public List<Education> Educations { get; set; }
        public List<Project> Projects { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
