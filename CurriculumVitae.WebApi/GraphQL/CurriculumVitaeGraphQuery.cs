using System;
using CurriculumVitae.Database;
using CurriculumVitae.GraphModels.Specifications;
using CurriculumVitae.GraphModels.Users;
using GraphQL.Types;

namespace CurriculumVitae.WebApi.GraphQL
{
    public class CurriculumVitaeGraphQuery : ObjectGraphType
    {
        public CurriculumVitaeGraphQuery(CurriculumVitaeDatabaseContext dbContext)
        {   
            Field<DetailedUserGraphType>(
                "complete user information",
                resolve: context => dbContext.DetailedUserInformation()
            );

            Field<UserGraphType>(
                "user information",
                resolve: context => dbContext.User()
            );

            Field<EducationGraphType>(
                "education information",
                arguments: new QueryArguments(new QueryArgument<IdGraphType> { Name = "Id", Description = "Id of the user queried" }),
                resolve: context => dbContext.Educations(context.GetArgument<Guid>("Id"))
            );

            Field<ProjectGraphType>(
                "project informatiom",
                arguments: new QueryArguments(new QueryArgument<IdGraphType> { Name = "Id", Description = "Id of the user queried" }),
                resolve: context => dbContext.Projects(context.GetArgument<Guid>("Id"))
            );

            Field<SkillGraphType>(
                "skill information",
                arguments: new QueryArguments(new QueryArgument<IdGraphType> { Name = "Id", Description = "Id of the user queried" }),
                resolve: context => dbContext.Skills(context.GetArgument<Guid>("Id"))
            );

            Field<WorkExperienceGraphType>(
                "work experience information",
                arguments: new QueryArguments(new QueryArgument<IdGraphType> { Name = "Id", Description = "Id of the user queried" }),
                resolve: context => dbContext.WorkExperiences(context.GetArgument<Guid>("Id"))
            );
        }
    }
}
