using shared.Protos;
using backend.Services;

namespace concert_service.Tests
{
    public class TicketingServiceTest
    {
        private TicketingInMemoryService _mockRepo;
        private backend.Services.TicketingService _service;

        [SetUp]
        public void SetUp()
        {
            _mockRepo = new TicketingInMemoryService();
            _service = new backend.Services.TicketingService(_mockRepo);
        }

        [Test]
        public async Task AddConcert_ShouldAddConcert()
        {

            Concert concert = new shared.Protos.Concert
            {
                Name = "Test Concert",
                Date = DateTime.Now.ToString()
            };

            var addedConcert = await _service.AddConcert(concert, null);

            Assert.That(addedConcert.Name, Is.EqualTo("Test Concert"));
        }
    }
}
