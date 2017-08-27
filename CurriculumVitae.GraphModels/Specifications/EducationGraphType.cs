using CurriculumVitae.DomainModels.Specifications;
using GraphQL.Types;

namespace CurriculumVitae.GraphModels.Specifications
{
    public class EducationGraphType : ObjectGraphType<Education>
    {
        public EducationGraphType()
        {
            Field(x => x.Start).Description("Start time of the education.");
            Field(x => x.End).Description("End time of the education.");
            Field(x => x.Description).Description("A description of the education.");
        }
    }
}