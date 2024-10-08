using Microsoft.EntityFrameworkCore;
using Wedgest.Data;
using Wedgest.Entities;
using Wedgest.Repositories;

namespace Wedgest.TicketRepo
{
    public class TiketRepository : GenaricRepository<Ticket>, ITicketRepositry
    { 
        private readonly ApplicationContext _context;
        public TiketRepository(ApplicationContext context) : base(context)
        {
            this._context = context;
        }

        
    }
}
