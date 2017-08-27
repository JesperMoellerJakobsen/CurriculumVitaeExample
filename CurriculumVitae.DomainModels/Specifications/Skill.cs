using System;

namespace CurriculumVitae.DomainModels.Specifications
{
    public class Skill
    {
        public Guid BelongsTo { get; set; }
        public string Description { get; set; }
    }
}
