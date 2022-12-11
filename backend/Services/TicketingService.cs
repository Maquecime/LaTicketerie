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

        public override async Task<shared.Protos.Reservation> AddReservation(shared.Protos.Reservation request, ServerCallContext context)
        {
            var reservation = ModelToGrpcConverter.ReservationGrpcToModel(request);
            await _repo.AddReservation(reservation);
            return request;
        }

        public override async Task<shared.Protos.Concert> DeleteConcert(shared.Protos.ConcertId request, ServerCallContext context)
        {
            var concert = await _repo.GetConcertById(request.Id);
            var grpcConcert = ModelToGrpcConverter.ConcertModelToGrpc(concert);
            await _repo.DeleteConcert(concert.Id);
            return grpcConcert;
        }

        public override async Task<shared.Protos.Reservation> DeleteReservation(shared.Protos.ReservationId request, ServerCallContext context)
        {
            var reserv = await _repo.GetReservationById(request.Id);
            var grpcReserv = ModelToGrpcConverter.ReservationModelToGrpc(reserv);
            await _repo.DeleteReservation(reserv.Id);
            return grpcReserv;
        }

        public override async Task<shared.Protos.Concerts> GetAllConcerts(shared.Protos.GetAllConcertsRequest request, ServerCallContext context)
        {
            var concerts = await _repo.GetAllConcerts();
            Concerts c = new();
            foreach (shared.Model.Concert concert in concerts)
            {
                c.Concert.Add(ModelToGrpcConverter.ConcertModelToGrpc(concert));
            }
            return c;
        }

        public override async Task<shared.Protos.Reservations> GetAllReservations(shared.Protos.GetAllReservationsRequest request, ServerCallContext context)
        {
            var reservs = await _repo.GetAllReservations();
            Reservations r = new();
            foreach (shared.Model.Reservation reservation in reservs)
            {
                r.Reservation.Add(ModelToGrpcConverter.ReservationModelToGrpc(reservation));
            }
            return r;
        }

        public override async Task<shared.Protos.Concert> UpdateConcert(shared.Protos.Concert request, ServerCallContext context)
        {
            var concert = ModelToGrpcConverter.ConcertGrpcToModel(request);
            await _repo.UpdateConcert(concert);
            return request;
        }

        public override async Task<shared.Protos.Reservation> UpdateReservation(shared.Protos.Reservation request, ServerCallContext context)
        {
            var reserv = ModelToGrpcConverter.ReservationGrpcToModel(request);
            await _repo.UpdateReservation(reserv);
            return request;
        }
    }
}
