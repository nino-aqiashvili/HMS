using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Shared.HMS.Tests
{
    ublic class HotelServiceTests
    {
        private readonly Mock<IHotelRepository> _hotelRepositoryMock;
        private readonly HotelService _hotelService;

        public HotelServiceTests()
        {
            _hotelRepositoryMock = new Mock<IHotelRepository>();
            _hotelService = new HotelService(_hotelRepositoryMock.Object);
        }

        [Fact]
        public async Task GetAllHotels_ShouldReturnHotels()
        {
            _hotelRepositoryMock.Setup(repo => repo.GetAllAsync())
                .ReturnsAsync(new List<Hotel> { new Hotel { Id = 1, Name = "Hotel A" } });

            var result = await _hotelService.GetAllHotelsAsync();

            Assert.Single(result);
            Assert.Equal("Hotel A", result[0].Name);
        }
    }
}
