using backend.Services;

public class TicketingRepository : ITicketingRepository
{
    private readonly TicketingContext _context;

    public TicketingRepository(TicketingContext context)
    {
        _context = context;
    }

    public Task<Concert> AddConcert(Concert concert)
    {
        throw new NotImplementedException();
    }

    public Task<Reservation> AddReservation(Reservation reservation)
    {
        throw new NotImplementedException();
    }

    public Task<Concert> DeleteConcert(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Reservation> DeleteReservation(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Concert>> GetAllConcerts()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Reservation>> GetAllReservations()
    {
        throw new NotImplementedException();
    }

    public Task<Concert> UpdateConcert(Concert concert)
    {
        throw new NotImplementedException();
    }

    public Task<Reservation> UpdateReservation(Reservation reservation)
    {
        throw new NotImplementedException();
    }
}