using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        #endregion

        #region constractur
        public TicketController(ITicketRepositry ticketRepositry)
        {
            _ticketRepositry = ticketRepositry;
        }
        #endregion

        [HttpGet("Tickets")]
        public async Task<ActionResult<IEnumerable<Ticket>>> GetAll()
        {
            var tickets =await _ticketRepositry.GetAll();
            return Ok(tickets);
        }
        [HttpGet("Tickets/{id:int}")]
        public async Task<ActionResult<Ticket>> Get(int id)
        {
           var TicketById=await _ticketRepositry.Get(id);
            return Ok(TicketById);
        }

        [HttpPost("Tickets")]
        public IActionResult Post(Ticket ticket)
        {
            var AddedTicket= _ticketRepositry.Add(ticket);
            return Ok(AddedTicket);
        }

        [HttpPut("Tickets")]
        public async  Task<IActionResult> Edite(int id,Ticket ticket)
        {
            var updatedTicked = await _ticketRepositry.Get(id);
            if (updatedTicked != null) 
            {
                updatedTicked.Title= ticket.Title;
                updatedTicked.Description= ticket.Description;
                updatedTicked.Status= ticket.Status;
                updatedTicked.FromData= ticket.FromData;
                updatedTicked.ToData= ticket.ToData;
               
                 return Ok(updatedTicked);

            }
            return Ok($"this {id} IS Not Exist  ");
        }


        [HttpDelete("Tickets/{id:int}")]

        public async Task<IActionResult> Delete(int id)
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
