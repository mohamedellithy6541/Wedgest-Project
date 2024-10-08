using Wedgest.Entities;
using Wedgest.Repositories;

namespace Wedgest.TicketRepo
{
    public interface ITicketRepositry :IGenaricRepository<Ticket>
    {

        //Task<Ticket> CreateAsync(Ticket ticket);
    }
}
