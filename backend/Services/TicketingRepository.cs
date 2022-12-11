using backend.Model;
using backend.Services;
using shared;
using shared.Model;

public class TicketingRepository : ITicketingRepository
{
    private readonly TicketingContext _context;

    public TicketingRepository(TicketingContext context)
    {
        _context = context;
    }

    public async Task<Concert> AddConcert(Concert concert)
    {
        _context.Concerts.Add(concert);
        await _context.SaveChangesAsync();
        return concert;
    }

    public async Task<Reservation> AddReservation(Reservation reservation)
    {
        _context.Reservations.Add(reservation);
        await _context.SaveChangesAsync();
        return reservation;
    }

    public async Task<Concert> DeleteConcert(int id)
    {
        Concert? c = await _context.Concerts.FindAsync(id);
        if (c != null)
        {
            _context.Concerts.Remove(c);
            await _context.SaveChangesAsync();
        }
        return c;
    }

    public async Task<Reservation> DeleteReservation(int id)
    {
        Reservation? r = await _context.Reservations.FindAsync(id);
        if (r != null)
        {
            _context.Reservations.Remove(r);
            await _context.SaveChangesAsync();
        }
        return r;
    }

    public async Task<IEnumerable<Concert>> GetAllConcerts()
    {
        return _context.Concerts.ToList();
    }

    public async Task<IEnumerable<Reservation>> GetAllReservations()
    {
        return _context.Reservations.ToList();
    }

    public async Task<Concert> GetConcertById(int id)
    {
        return _context.Concerts.Where(c => c.Id == id).FirstOrDefault();
    }

    public async Task<Reservation> GetReservationById(int id)
    {
        return _context.Reservations.Where(r => r.Id == id).FirstOrDefault();
    }

    public async Task<Concert> UpdateConcert(Concert concert)
    {
        Concert? c = await _context.Concerts.FindAsync(concert.Id);
        if (c != null)
        {
            _context.Concerts.Update(c);
        }

        await _context.SaveChangesAsync();
        return c;
    }

    public async Task<Reservation> UpdateReservation(Reservation reservation)
    {
        Reservation? r = await _context.Reservations.FindAsync(reservation.Id);
        if (r != null)
        {
            _context.Reservations.Update(r);
        }

        await _context.SaveChangesAsync();
        return r;
    }
}