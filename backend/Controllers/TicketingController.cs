namespace backend.Controllers
{
    using backend.Services;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class TicketingController : ControllerBase
    {
        private readonly ITicketingRepository _ticketingRepo;

        public TicketingController(ITicketingRepository ticketingRepository)
        {
            _ticketingRepo = ticketingRepository;
        }

        [HttpGet("concerts")]
        public async Task<IActionResult> GetAllConcerts()
        {
            IEnumerable<Concert> concerts = await _ticketingRepo.GetAllConcerts();
            return Ok(concerts);
        }
    }
}