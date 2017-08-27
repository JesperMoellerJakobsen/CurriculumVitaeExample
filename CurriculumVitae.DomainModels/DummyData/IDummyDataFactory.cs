using System;
using System.Collections.Generic;
using CurriculumVitae.DomainModels.Specifications;
using CurriculumVitae.DomainModels.Users;

namespace CurriculumVitae.DomainModels.DummyData
{
    public interface IDummyDataFactory
    {
        User MakeUser();
        List<Education> MakeEducations();
        List<Project> MakeProjects();
        List<Skill> MakeSkills();
        List<Company> MakeCompanies();
    }
}