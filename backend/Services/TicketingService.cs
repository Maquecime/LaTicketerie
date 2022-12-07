using backend.Protos;
using Grpc.Core;

namespace backend.Services
{
    public class TicketingService : backend.Protos.TicketingService.TicketingServiceBase
    {
        private readonly ITicketingRepository _repo;

        public TicketingService(ITicketingRepository repo)
        {
            _repo = repo;
        }

        public override Task<Protos.Concert> AddConcert(Protos.Concert request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }

        public override Task<Protos.Reservation> AddReservation(Protos.Reservation request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }

        public override Task<Protos.Concert> DeleteConcert(ConcertId request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }

        public override Task<Protos.Reservation> DeleteReservation(ReservationId request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object? obj)
        {
            throw new NotImplementedException();
        }

        public override Task<Concerts> GetAllConcerts(GetAllConcertsRequest request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }

        public override Task<Reservations> GetAllReservations(GetAllReservationsRequest request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }

        public override Task<Protos.Concert> UpdateConcert(Protos.Concert request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }

        public override Task<Protos.Reservation> UpdateReservation(Protos.Reservation request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }
    }
}
