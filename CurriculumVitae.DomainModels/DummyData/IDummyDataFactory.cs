using System;
using System.Collections.Generic;
using CurriculumVitae.DomainModels.Specifications;
using CurriculumVitae.DomainModels.Users;

namespace CurriculumVitae.DomainModels.DummyData
{
    public interface IDummyDataFactory
    {
        User MakeUser();
        List<Education> MakeEducations(Guid userId);
        List<Project> MakeProjects(Guid userId);
        List<Skill> MakeSkills(Guid userId);
        List<WorkExperience> MakeWorkExperiences(Guid userId);
    }
}