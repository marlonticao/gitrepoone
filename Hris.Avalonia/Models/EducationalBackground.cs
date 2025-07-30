using System;
using System.Collections.Generic;

namespace Hris.Avalonia.Models
{
    public class EducationalBackground
    {
        public EducationDetails? Elementary { get; set; }
        public EducationDetails? Secondary { get; set; }
        public EducationDetails? VocationalTradeCourse { get; set; }
        public EducationDetails? College { get; set; }
        public EducationDetails? GraduateStudies { get; set; }
    }

    public class EducationDetails
    {
        public string? SchoolName { get; set; }
        public string? BasicEducationDegreeCourse { get; set; }
        public string? PeriodOfAttendance { get; set; }
        public string? HighestLevelUnitsEarned { get; set; }
        public int? YearGraduated { get; set; }
        public string? ScholarshipAcademicHonors { get; set; }
    }
}
