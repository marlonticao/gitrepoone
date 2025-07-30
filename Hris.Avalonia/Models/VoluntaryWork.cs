using System;

namespace Hris.Avalonia.Models
{
    public class VoluntaryWork
    {
        public string? NameOfOrganization { get; set; }
        public DateTime InclusiveDateFrom { get; set; }
        public DateTime? InclusiveDateTo { get; set; }
        public int NumberOfHours { get; set; }
        public string? PositionNatureOfWork { get; set; }
    }
}
