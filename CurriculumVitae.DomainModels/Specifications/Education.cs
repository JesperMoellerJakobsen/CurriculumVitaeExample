using System;

namespace CurriculumVitae.DomainModels.Specifications
{
    public class Education
    {
        public Guid BelongsTo { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Description { get; set; }
    }
}
