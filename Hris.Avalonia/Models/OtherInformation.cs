using System.Collections.Generic;

namespace Hris.Avalonia.Models
{
    public class OtherInformation
    {
        public List<string> SpecialSkillsHobbies { get; set; } = new List<string>();
        public List<string> NonAcademicDistinctions { get; set; } = new List<string>();
        public List<string> MembershipInAssociations { get; set; } = new List<string>();
    }
}
