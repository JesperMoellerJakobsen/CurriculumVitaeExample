using CurriculumVitae.DomainModels.Specifications;
using GraphQL.Types;

namespace CurriculumVitae.GraphModels.Specifications
{
    public class CompanyGraphType : ObjectGraphType<Company>
    {
        public CompanyGraphType()
        {
            Field(x => x.CompanyName).Description("The name of the company, which gave the experience.");
            Field(x => x.Start).Description("The starttime of the company experience.");
            Field(x => x.End).Description("The endtime of the company experience.");
            Field(x => x.Position).Description("The position of the experience.");
            Field(x => x.Description).Description("A description of the experience.");
        }
    }
}