using AutoMapper;
using Wedgest.Entities;

namespace Wedgest.DTOS
{
    public class MapTickets: Profile
    {
        public MapTickets()
        {
            CreateMap<Ticket,TicketDtos>().ReverseMap();
        }
    }
}
