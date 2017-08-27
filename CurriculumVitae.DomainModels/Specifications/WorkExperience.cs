using System;

namespace CurriculumVitae.DomainModels.Specifications
{
    public class WorkExperience 
    {
        public Guid BelongsTo { get; set; }
        public string CompanyName { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
    }
}
