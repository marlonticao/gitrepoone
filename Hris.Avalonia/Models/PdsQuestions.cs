namespace Hris.Avalonia.Models
{
    public class PdsQuestions
    {
        public bool RelatedToAppointingAuthorityThirdDegree { get; set; }
        public string? RelatedToAppointingAuthorityThirdDegreeDetails { get; set; }
        public bool RelatedToAppointingAuthorityFourthDegree { get; set; }
        public string? RelatedToAppointingAuthorityFourthDegreeDetails { get; set; }
        public bool FoundGuiltyOfAdministrativeOffense { get; set; }
        public string? FoundGuiltyOfAdministrativeOffenseDetails { get; set; }
        public bool CriminallyCharged { get; set; }
        public string? CriminallyChargedDetails { get; set; }
        public bool ConvictedOfCrime { get; set; }
        public string? ConvictedOfCrimeDetails { get; set; }
        public bool SeparatedFromService { get; set; }
        public string? SeparatedFromServiceDetails { get; set; }
        public bool CandidateInElection { get; set; }
        public string? CandidateInElectionDetails { get; set; }
        public bool ResignedForElection { get; set; }
        public string? ResignedForElectionDetails { get; set; }
        public bool IndigenousGroupMember { get; set; }
        public string? IndigenousGroupMemberDetails { get; set; }
        public bool PersonWithDisability { get; set; }
        public string? PersonWithDisabilityDetails { get; set; }
        public bool SoloParent { get; set; }
        public string? SoloParentDetails { get; set; }
    }
}
