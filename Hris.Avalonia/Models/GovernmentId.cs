using System;

namespace Hris.Avalonia.Models
{
    public class GovernmentId
    {
        public string? IdType { get; set; }
        public string? IdNumber { get; set; }
        public DateTime DateOfIssuance { get; set; }
        public string? PlaceOfIssuance { get; set; }
    }
}
