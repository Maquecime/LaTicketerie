using Grpc.Net.Client;
using static shared.Protos.TicketingService;
using shared.Protos;
using backend.Services;

namespace concert_service.Tests
{
    public class TicketingServiceTest
    {
        private GrpcChannel _channel;
        private TicketingServiceClient _client;

        private TicketingInMemoryService _service;

        [SetUp]
        public void SetUp()
        {

            _channel = GrpcChannel.ForAddress("http://localhost:5293");
            _client = new TicketingServiceClient(_channel);
            _service = new TicketingInMemoryService();
        }

        [Test]
        public async Task AddConcert_ShouldAddConcert()
        {

            var concert = new shared.Model.Concert
            {
                Name = "Test Concert",
                Date = DateTime.Now
            };

            var addedConcert = await _service.AddConcert(concert);

            Assert.That(addedConcert.Name, Is.EqualTo("Test Concert"));
        }
    }
}
