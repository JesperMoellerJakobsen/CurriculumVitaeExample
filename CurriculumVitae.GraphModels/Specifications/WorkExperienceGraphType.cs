using CurriculumVitae.DomainModels.Specifications;
using GraphQL.Types;

namespace CurriculumVitae.GraphModels.Specifications
{
    public class WorkExperienceGraphType : ObjectGraphType<WorkExperience>
    {
        public WorkExperienceGraphType()
        {
            Field(x => x.BelongsTo, type: typeof(IdGraphType)).Description("The user which the work experience belongs to.");
            Field(x => x.CompanyName).Description("The name of the company, which gave the experience.");
            Field(x => x.Start).Description("The starttime of the company experience.");
            Field(x => x.End).Description("The endtime of the company experience.");
            Field(x => x.Position).Description("The position of the experience.");
            Field(x => x.Description).Description("A description of the experience.");
        }
    }
}