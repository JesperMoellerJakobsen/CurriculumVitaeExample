using System;
using System.Collections.Generic;
using CurriculumVitae.DomainModels.DummyData;
using CurriculumVitae.DomainModels.Specifications;
using CurriculumVitae.DomainModels.Users;
using Microsoft.EntityFrameworkCore;

namespace CurriculumVitae.Database
{
    public class CurriculumVitaeDatabaseContext : DbContext
    {
        private readonly IDummyDataFactory dummyDataFactory;

        /// <summary>
        /// This should act like a database context (Using entity framework)
        /// I'm leaving out the actual database from this example, and will just return dummy data
        /// </summary>
        public CurriculumVitaeDatabaseContext(IDummyDataFactory dummyDataFactory)
            : base(new DbContextOptionsBuilder().Options)
        {
            this.dummyDataFactory = dummyDataFactory;
        }

        public DetailedUser DetailedUserInformation()
        {
            var user = dummyDataFactory.MakeUser();
            return new DetailedUser
            {
                User = user,
                Educations = Educations(user.Id),
                Skills = Skills(user.Id),
                Projects = Projects(user.Id),
                WorkExperiences = WorkExperiences(user.Id)
            };
        }

        public User User()
        {
            return dummyDataFactory.MakeUser();
        }

        public List<Education> Educations(Guid userId)
        {
            return dummyDataFactory.MakeEducations(userId);
        }

        public List<Project> Projects(Guid userId)
        {
            return dummyDataFactory.MakeProjects(userId);
        }

        public List<Skill> Skills(Guid userId)
        {
            return dummyDataFactory.MakeSkills(userId);
        }

        public List<WorkExperience> WorkExperiences(Guid userId)
        {
            return dummyDataFactory.MakeWorkExperiences(userId);
        }
    }
}
