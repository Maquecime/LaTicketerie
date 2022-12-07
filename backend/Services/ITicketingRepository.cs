using shared;
using shared.Model;

namespace backend.Services
{
    public interface ITicketingRepository
    {
        Task<Concert> AddConcert(Concert concert);
        Task<Concert> UpdateConcert(Concert concert);
        Task<Concert> DeleteConcert(int id);
        Task<IEnumerable<Concert>> GetAllConcerts();
        Task<Concert> GetConcertById(int id);
        Task<Reservation> AddReservation(Reservation reservation);
        Task<Reservation> UpdateReservation(Reservation reservation);
        Task<Reservation> DeleteReservation(int id);
        Task<IEnumerable<Reservation>> GetAllReservations();
        Task<Reservation> GetReservationById(int id);

    }
}