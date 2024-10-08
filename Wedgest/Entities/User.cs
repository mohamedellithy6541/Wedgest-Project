using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Wedgest.Entities
{
    public class User
    {
        [Key]
        public int id { get; set; }
       
        public int userName { get; set; }
        public int age { get; set; }

        public string? job { get; set; }

        public ICollection<Ticket>? Tickets { get; set; }

    }
}
