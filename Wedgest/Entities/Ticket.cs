using System.ComponentModel.DataAnnotations;

namespace Wedgest.Entities
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? FromData { get; set; }
        public DateTime? ToData { get; set; }
        public Status Status { get; set; }
        public int userId { get; set; }
        public User? user { get; set; }



    }
}
