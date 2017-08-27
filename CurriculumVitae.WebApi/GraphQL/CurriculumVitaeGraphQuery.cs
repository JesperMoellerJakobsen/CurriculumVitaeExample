using CurriculumVitae.Database;
using CurriculumVitae.GraphModels.Specifications;
using CurriculumVitae.GraphModels.Users;
using GraphQL.Types;

namespace CurriculumVitae.WebApi.GraphQL
{
    public class CurriculumVitaeGraphQuery : ObjectGraphType
    {
        public CurriculumVitaeGraphQuery(ICurriculumVitaeDatabaseContext dbContext)
        {
            Field<DetailedUserGraphType>(
                "curriculumvitae",
                resolve: context => dbContext.DetailedUserInformation()
            );

            Field<UserGraphType>(
                "user",
                resolve: context => dbContext.User()
            );

            Field<EducationGraphType>(
                "education",
                arguments: new QueryArguments(new QueryArgument<IdGraphType> { Name = "Id", Description = "Id of the user queried" }),
                resolve: context => dbContext.Educations()
            );

            Field<ProjectGraphType>(
                "project",
                arguments: new QueryArguments(new QueryArgument<IdGraphType> { Name = "Id", Description = "Id of the user queried" }),
                resolve: context => dbContext.Projects()
            );

            Field<SkillGraphType>(
                "skill",
                arguments: new QueryArguments(new QueryArgument<IdGraphType> { Name = "Id", Description = "Id of the user queried" }),
                resolve: context => dbContext.Skills()
            );

            Field<CompanyGraphType>(
                "workexperience",
                arguments: new QueryArguments(new QueryArgument<IdGraphType> { Name = "Id", Description = "Id of the user queried" }),
                resolve: context => dbContext.Companies()
            );
        }
    }
}
