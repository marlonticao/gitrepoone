using System;

namespace Hris.Avalonia.Models
{
    public class CivilServiceEligibility
    {
        public string? CareerService { get; set; }
        public double? Rating { get; set; }
        public DateTime DateOfExamination { get; set; }
        public string? PlaceOfExamination { get; set; }
        public string? LicenseNumber { get; set; }
        public DateTime DateOfValidity { get; set; }
    }
}
