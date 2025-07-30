using System;
using System.Collections.Generic;

namespace Hris.Avalonia.Models
{
    public class FamilyBackground
    {
        public string? FathersSurname { get; set; }
        public string? FathersFirstName { get; set; }
        public string? FathersMiddleName { get; set; }
        public string? FathersNameExtension { get; set; }
        public string? MothersMaidenName { get; set; }
        public string? MothersSurname { get; set; }
        public string? MothersFirstName { get; set; }
        public string? MothersMiddleName { get; set; }
        public string? SpouseSurname { get; set; }
        public string? SpouseFirstName { get; set; }
        public string? SpouseMiddleName { get; set; }
        public string? SpouseNameExtension { get; set; }
        public string? SpouseOccupation { get; set; }
        public string? SpouseEmployer { get; set; }
        public string? SpouseBusinessAddress { get; set; }
        public string? SpouseTelephoneNo { get; set; }
        public List<Child> Children { get; set; } = new List<Child>();
    }

    public class Child
    {
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
