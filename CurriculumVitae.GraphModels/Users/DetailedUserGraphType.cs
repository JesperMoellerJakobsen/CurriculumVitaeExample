using CurriculumVitae.Database;
using CurriculumVitae.DomainModels.DummyData;
using CurriculumVitae.DomainModels.Users;
using CurriculumVitae.GraphModels.Specifications;
using GraphQL.Types;

namespace CurriculumVitae.GraphModels.Users
{
    public class DetailedUserGraphType : ObjectGraphType<DetailedUser>
    {
        public DetailedUserGraphType()
        {
            //Graphtype DI with autofac is not functional. Maybe change to simpleContainer or microsoft di?
            //Read https://github.com/graphql-dotnet/graphql-dotnet/issues/97
            var dbContext = new CurriculumVitaeDatabaseContext(new DummyDataFactory());

            Field(x => x.User, type: typeof(UserGraphType)).Description("The user of the curriculum vitae.");
            Field<ListGraphType<CompanyGraphType>>("Companies", resolve: context => dbContext.Companies(), description: "Company work experience(s) of the user.");
            Field<ListGraphType<EducationGraphType>>("Educations", resolve: context => dbContext.Educations(), description: "Education(s) of the user.");
            Field<ListGraphType<ProjectGraphType>>("Projects", resolve: context => dbContext.Projects(), description: "Project(s) of the user.");
            Field<ListGraphType<SkillGraphType>>("Skills", resolve: context => dbContext.Skills(), description: "Skill(s) of the user.");
        }
    }
}