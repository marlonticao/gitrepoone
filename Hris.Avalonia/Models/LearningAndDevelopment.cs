using System;

namespace Hris.Avalonia.Models
{
    public class LearningAndDevelopment
    {
        public string? Title { get; set; }
        public DateTime InclusiveDateFrom { get; set; }
        public DateTime? InclusiveDateTo { get; set; }
        public int NumberOfHours { get; set; }
        public string? TypeOfLd { get; set; }
        public string? ConductedSponsoredBy { get; set; }
    }
}
