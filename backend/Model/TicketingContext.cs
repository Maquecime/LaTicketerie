
using Microsoft.EntityFrameworkCore;
using shared;

public class TicketingContext : DbContext
{
    public DbSet<Concert> Concerts { get; set; }
    public DbSet<Reservation> Reservations { get; set; }

    /// <summary>
    /// Ctor for <see href="TicketingContext"/>
    /// </summary>
    /// <param name="options"></param>
    /// <returns></returns>
    public TicketingContext(DbContextOptions options) : base(options)
    {
    }
}