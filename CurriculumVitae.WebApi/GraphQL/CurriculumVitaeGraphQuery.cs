using CurriculumVitae.Database;
using CurriculumVitae.GraphModels.Specifications;
using CurriculumVitae.GraphModels.Users;
using GraphQL.Types;

namespace CurriculumVitae.WebApi.GraphQL
{
    public class CurriculumVitaeGraphQuery : ObjectGraphType
    {
        //Arguments not used since im not querying any database.
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

            Field<ListGraphType<EducationGraphType>>(
                "education",
                arguments: new QueryArguments(new QueryArgument<IdGraphType> { Name = "Id", Description = "Id of the user queried" }),
                resolve: context => dbContext.Educations()
            );

            Field<ListGraphType<ProjectGraphType>>(
                "project",
                arguments: new QueryArguments(new QueryArgument<IdGraphType> { Name = "Id", Description = "Id of the user queried" }),
                resolve: context => dbContext.Projects()
            );

            Field<ListGraphType<SkillGraphType>>(
                "skill",
                arguments: new QueryArguments(new QueryArgument<IdGraphType> { Name = "Id", Description = "Id of the user queried" }),
                resolve: context => dbContext.Skills()
            );

            Field<ListGraphType<CompanyGraphType>>(
                "company",
                arguments: new QueryArguments(new QueryArgument<IdGraphType> { Name = "Id", Description = "Id of the user queried" }),
                resolve: context => dbContext.Companies()
            );
        }
    }
}
