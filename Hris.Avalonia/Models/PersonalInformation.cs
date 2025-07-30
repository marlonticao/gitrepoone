using System;

namespace Hris.Avalonia.Models
{
    public class PersonalInformation
    {
        public string? Surname { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? NameExtension { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string? BloodType { get; set; }
        public string? GsisIdNo { get; set; }
        public string? PagIbigIdNo { get; set; }
        public string? PhilHealthNo { get; set; }
        public string? SssNo { get; set; }
        public string? TinNo { get; set; }
        public string? AgencyEmployeeNo { get; set; }
        public string? Citizenship { get; set; }
        public string? ResidentialAddress { get; set; }
        public string? PermanentAddress { get; set; }
        public string? TelephoneNo { get; set; }
        public string? MobileNo { get; set; }
        public string? EmailAddress { get; set; }
    }
}
