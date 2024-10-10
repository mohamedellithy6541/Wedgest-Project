using Wedgest.Entities;

namespace Wedgest.DTOS
{
    public class TicketDtos
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? FromData { get; set; }
        public DateTime? ToData { get; set; }
        public Status Status { get; set; }
        public int? userId { get; set; }
    }
}
