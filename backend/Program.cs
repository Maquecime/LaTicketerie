using backend.Services;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

try
{
    int grpcPort = int.Parse(Environment.GetEnvironmentVariable("GRPC_PORT") ?? "5293");
    builder.WebHost.ConfigureKestrel(options =>
    {
        options.ListenLocalhost(grpcPort, o => o.Protocols =
            HttpProtocols.Http2);
    });
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ITicketingRepository, TicketingRepository>();
builder.Services.AddDbContext<TicketingContext>(x => x.UseSqlite(builder.Configuration.GetConnectionString("TicketingContext")));
builder.Services.AddGrpc();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapGrpcService<TicketingService>();
app.MapControllers();


app.Run();
