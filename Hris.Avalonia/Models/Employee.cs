using System.Collections.Generic;

namespace Hris.Avalonia.Models
{
    public class Employee
    {
        public string? PersonnelIdNumber { get; set; }
        public PersonalInformation PersonalInformation { get; set; } = new PersonalInformation();
        public FamilyBackground FamilyBackground { get; set; } = new FamilyBackground();
        public EducationalBackground EducationalBackground { get; set; } = new EducationalBackground();
        public List<CivilServiceEligibility> CivilServiceEligibilities { get; set; } = new List<CivilServiceEligibility>();
        public List<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();
        public List<VoluntaryWork> VoluntaryWorks { get; set; } = new List<VoluntaryWork>();
        public List<LearningAndDevelopment> LearningAndDevelopments { get; set; } = new List<LearningAndDevelopment>();
        public OtherInformation OtherInformation { get; set; } = new OtherInformation();
        public PdsQuestions PdsQuestions { get; set; } = new PdsQuestions();
        public List<Reference> References { get; set; } = new List<Reference>();
        public GovernmentId GovernmentId { get; set; } = new GovernmentId();
    }
}
