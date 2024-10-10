using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wedgest.DTOS;
using Wedgest.Entities;
using Wedgest.TicketRepo;

namespace Wedgest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        #region Field
        private readonly ITicketRepositry _ticketRepositry;
        private readonly IMapper _mapper;
        #endregion
        #region constractur
        public TicketController(ITicketRepositry ticketRepositry, IMapper mapper)
        {
            _ticketRepositry = ticketRepositry;
            _mapper = mapper;
        }
        #endregion

        [HttpGet("Tickets")]
        public async Task<ActionResult<IEnumerable<TicketDtos>>> GetAll()
        {
            var tickets = await _ticketRepositry.GetAll();
            var TicketDto = _mapper.Map<IEnumerable<TicketDtos>>(tickets);
            return Ok(TicketDto);
        }
        [HttpGet("Tickets/{id:int}")]
        public async Task<ActionResult<TicketDtos>> Get(int id)
        {
            if (id == 0 )
            {
                return NotFound($"This {id} Is Not Found");
            }
            else
            {
                var TicketById = await _ticketRepositry.Get(id);
                var TicketDto = _mapper.Map<TicketDtos>(TicketById);
                return Ok(TicketDto);
            }
        }
        [HttpPost("Tickets")]
        public async Task<ActionResult<TicketDtos>> Post(TicketDtos ticket)
        {
            var Ticketsrc = new Ticket()
            {
                Description = ticket.Description,
                FromData = ticket.FromData,
                Status = ticket.Status,
                TicketId = ticket.TicketId,
                ToData = ticket.ToData,
                Title = ticket.Title,
                userId = ticket.userId

            };
            var TicketDto = _mapper.Map<TicketDtos>(Ticketsrc);
            await _ticketRepositry.Add(Ticketsrc);
            return Ok(TicketDto);
        }
        [HttpPut("Tickets")]
        public async Task<ActionResult<TicketDtos>> Edite(int id, TicketDtos ticket)
        {   if (id==0) 
            return BadRequest("please Enter Valid Id ");
            var updatedTicked = await _ticketRepositry.Get(id);
            if (updatedTicked != null)
            {
                updatedTicked.Title = ticket.Title;
                updatedTicked.Description = ticket.Description;
                updatedTicked.Status = ticket.Status;
                updatedTicked.FromData = ticket.FromData;
                updatedTicked.ToData = ticket.ToData;
                _ticketRepositry?.Updated(id, updatedTicked);
                var TicketDto =  _mapper.Map<TicketDtos>(updatedTicked);
                return Ok(TicketDto);
            }
            return Ok($"this {id} IS Not Exist  ");
        }
        [HttpDelete("Tickets/{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (id != 0)
            {
               _ticketRepositry.Delete(id);
                return Ok();
            }
            return Ok($"This {id} is not Exist");
        }
    }
}
