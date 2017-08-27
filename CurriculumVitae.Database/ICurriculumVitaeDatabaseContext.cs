using System;
using System.Collections.Generic;
using CurriculumVitae.DomainModels.Specifications;
using CurriculumVitae.DomainModels.Users;

namespace CurriculumVitae.Database
{
    public interface ICurriculumVitaeDatabaseContext
    {
        DetailedUser DetailedUserInformation();
        User User();
        List<Education> Educations();
        List<Project> Projects();
        List<Skill> Skills();
        List<Company> Companies();
    }
}