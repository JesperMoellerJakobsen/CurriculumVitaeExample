using CurriculumVitae.DomainModels.Specifications;
using GraphQL.Types;

namespace CurriculumVitae.GraphModels.Specifications
{
    public class ProjectGraphType : ObjectGraphType<Project>
    {
        public ProjectGraphType()
        {
            Field(x => x.BelongsTo, type: typeof(IdGraphType)).Description("The user which the project belongs to.");
            Field(x => x.Start).Description("Start time of the project.");
            Field(x => x.End).Description("End time of the project.");
            Field(x => x.Description).Description("A description of the project.");
        }
    }
}