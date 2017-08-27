using System;
using System.Collections.Generic;
using CurriculumVitae.DomainModels.DummyData;
using CurriculumVitae.DomainModels.Specifications;
using CurriculumVitae.DomainModels.Users;
using Microsoft.EntityFrameworkCore;

namespace CurriculumVitae.Database
{
    public class CurriculumVitaeDatabaseContext : DbContext, ICurriculumVitaeDatabaseContext
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
                Educations = Educations(),
                Skills = Skills(),
                Projects = Projects(),
                Companies = Companies()
            };
        }

        public User User()
        {
            return dummyDataFactory.MakeUser();
        }

        public List<Education> Educations()
        {
            return dummyDataFactory.MakeEducations();
        }

        public List<Project> Projects()
        {
            return dummyDataFactory.MakeProjects();
        }

        public List<Skill> Skills()
        {
            return dummyDataFactory.MakeSkills();
        }

        public List<Company> Companies()
        {
            return dummyDataFactory.MakeCompanies();
        }
    }
}
