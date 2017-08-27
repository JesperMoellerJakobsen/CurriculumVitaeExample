using CurriculumVitae.Database;
using CurriculumVitae.DomainModels.Users;
using CurriculumVitae.GraphModels.Specifications;
using GraphQL.Types;

namespace CurriculumVitae.GraphModels.Users
{
    public class DetailedUserGraphType : ObjectGraphType<DetailedUser>
    {
        public DetailedUserGraphType(CurriculumVitaeDatabaseContext databaseContext)
        {
            Field(x => x.User, type: typeof(UserGraphType)).Description("The user of the request.");
            Field<ListGraphType<WorkExperienceGraphType>>("Work experiences", 
                resolve: context=> databaseContext.WorkExperiences(context.Source.User.Id), 
                description: "Company work experience(s) of the user.");
            Field(x => x.Educations, type: typeof(EducationGraphType)).Description("Education(s) of the user.");
            Field(x => x.Projects, type: typeof(ProjectGraphType)).Description("Project(s) of the user.");
            Field(x => x.Skills, type: typeof(SkillGraphType)).Description("Skill(s) of the user.");
        }
    }
}