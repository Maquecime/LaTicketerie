using shared.Model;

namespace backend.Services;

public class TicketingInMemoryService : ITicketingRepository
{
    private static List<Concert> _concerts = new();
    private static List<Reservation> _reservations = new();

    public Task<Concert> AddConcert(Concert concert)
    {
        _concerts.Add(concert);
        return Task.FromResult(concert);
    }

    public Task<Reservation> AddReservation(Reservation reservation)
    {
        throw new NotImplementedException();
    }

    public Task<Concert> DeleteConcert(int id)
    {
        Concert? c = _concerts.Where(c => c.Id == id).FirstOrDefault();
        if (c != null)
        {
            _concerts.Remove(c);
        }
        return Task.FromResult(c);
    }

    public Task<Reservation> DeleteReservation(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Concert>> GetAllConcerts()
    {
        return Task.FromResult(_concerts.AsEnumerable());
    }

    public Task<IEnumerable<Reservation>> GetAllReservations()
    {
        throw new NotImplementedException();
    }

    public Task<Concert> GetConcertById(int id)
    {
        return Task.FromResult(_concerts.Where(c => c.Id == id).FirstOrDefault());
    }

    public Task<Reservation> GetReservationById(int id)
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
