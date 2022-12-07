using System;

public class Reservation
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Email { get; set; }
    public string PaymentMethod { get; set; }
    public decimal Price { get; set; }
    public int ConcertId { get; set; }
    public Concert Concert { get; set; }
}