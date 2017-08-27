using CurriculumVitae.DomainModels.Specifications;
using GraphQL.Types;

namespace CurriculumVitae.GraphModels.Specifications
{
    public class SkillGraphType : ObjectGraphType<Skill>
    {
        public SkillGraphType()
        {
            Field(x => x.Description).Description("A description of the skill.");
        }
    }
}