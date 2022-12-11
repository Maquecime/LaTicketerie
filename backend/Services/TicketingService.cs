using backend.Converters;
using Grpc.Core;
using shared.Protos;

namespace backend.Services
{
    public class TicketingService : shared.Protos.TicketingService.TicketingServiceBase
    {
        private readonly ITicketingRepository _repo;

        public TicketingService(ITicketingRepository repo)
        {
            _repo = repo;
        }

        public async override Task<shared.Protos.Concert> AddConcert(Concert request, ServerCallContext context)
        {
            var concert = backend.Converters.ModelToGrpcConverter.ConcertGrpcToModel(request);

            await _repo.AddConcert(concert);
            return request;
        }

        public override Task<shared.Protos.Reservation> AddReservation(shared.Protos.Reservation request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }

        public override Task<shared.Protos.Concert> DeleteConcert(shared.Protos.ConcertId request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }

        public override Task<shared.Protos.Reservation> DeleteReservation(shared.Protos.ReservationId request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object? obj)
        {
            throw new NotImplementedException();
        }

        public override Task<shared.Protos.Concerts> GetAllConcerts(shared.Protos.GetAllConcertsRequest request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }

        public override Task<shared.Protos.Reservations> GetAllReservations(shared.Protos.GetAllReservationsRequest request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }

        public override Task<shared.Protos.Concert> UpdateConcert(shared.Protos.Concert request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }

        public override Task<shared.Protos.Reservation> UpdateReservation(shared.Protos.Reservation request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }
    }
}
