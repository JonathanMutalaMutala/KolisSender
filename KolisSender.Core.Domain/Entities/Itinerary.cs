using System.ComponentModel.DataAnnotations;

namespace KolisSender.Core.Domain.Entities
{
    public class Itinerary
    {
        public string Id { get; set; }
        public string DepartureAirport { get; set; } = default!; 
        public string DestinationAirport { get; set; } = default!; 
        public string DepartureCountry { get; set; } = default!;
        public string DestinationCountry { get; set; } = default!; 
        public string DepartureCity { get; set; } = default!; 
        public string DestinationCity { get; set; } = default!;
        public bool IsActive { get; set; } 
        public bool IsValid { get; set; }

        [Required]
        public DateTime DepartureDate { get; set; }
        [Required]
        public DateTime DestinationDate { get; set; }

    }
}
