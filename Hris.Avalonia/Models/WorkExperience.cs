using System;

namespace Hris.Avalonia.Models
{
    public class WorkExperience
    {
        public DateTime InclusiveDateFrom { get; set; }
        public DateTime? InclusiveDateTo { get; set; }
        public string? PositionTitle { get; set; }
        public string? DepartmentAgencyOffice { get; set; }
        public double MonthlySalary { get; set; }
        public string? SalaryGrade { get; set; }
        public string? StatusOfAppointment { get; set; }
        public bool IsGovernmentService { get; set; }
    }
}
