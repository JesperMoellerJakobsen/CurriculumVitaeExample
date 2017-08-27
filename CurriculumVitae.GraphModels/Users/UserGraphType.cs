using CurriculumVitae.Database;
using CurriculumVitae.DomainModels.DummyData;
using CurriculumVitae.DomainModels.Users;
using GraphQL.Types;

namespace CurriculumVitae.GraphModels.Users
{
    public class UserGraphType : ObjectGraphType<User>
    {
        public UserGraphType()
        {
            Field(x => x.FirstName).Description("Firstname of the user.");
            Field(x => x.LastName).Description("Lastname of the user.");
            Field(x => x.Email).Description("Email of the user.");
        }
    }
}