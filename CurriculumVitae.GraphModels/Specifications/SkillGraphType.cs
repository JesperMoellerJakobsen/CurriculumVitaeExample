using CurriculumVitae.DomainModels.Specifications;
using GraphQL.Types;

namespace CurriculumVitae.GraphModels.Specifications
{
    public class SkillGraphType : ObjectGraphType<Skill>
    {
        public SkillGraphType()
        {
            Field(x => x.BelongsTo, type: typeof(IdGraphType)).Description("The user which the skill belongs to.");
            Field(x => x.Description).Description("A description of the skill.");
        }
    }
}