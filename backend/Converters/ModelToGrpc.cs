namespace backend.Converters;
public class ModelToGrpcConverter
{
    public static shared.Protos.Concert ConcertModelToGrpc(shared.Model.Concert c)
    {
        return new shared.Protos.Concert()
        {
            Date = c.Date.ToString(),
            Id = c.Id,
            Name = c.Name
        };
    }

    public static shared.Model.Concert ConcertGrpcToModel(shared.Protos.Concert c)
    {
        return new shared.Model.Concert()
        {
            Date = DateTime.Parse(c.Date),
            Id = c.Id,
            Name = c.Name
        };
    }

    public static shared.Protos.Reservation ReservationModelToGrpc(shared.Model.Reservation r)
    {
        return new shared.Protos.Reservation()
        {
            ConcertId = r.ConcertId,
            Date = r.Date.ToString(),
            Email = r.Email,
            Id = r.Id,
            PaymentMethod = r.PaymentMethod,
            Price = ((double)r.Price)
        };
    }

    public static shared.Model.Reservation ReservationModelToGrpc(shared.Protos.Reservation r)
    {
        return new shared.Model.Reservation()
        {
            ConcertId = r.ConcertId,
            Date = DateTime.Parse(r.Date),
            Email = r.Email,
            Id = r.Id,
            PaymentMethod = r.PaymentMethod,
            Price = ((decimal)r.Price)
        };
    }
}