using HMS.Models;
using HMS.Repositories;

namespace HMS.Services
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;

        public HotelService(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public async Task<IEnumerable<Hotel>> GetHotelsAsync() => await _hotelRepository.GetHotelsAsync();

        public async Task<Hotel> GetHotelByIdAsync(int id) => await _hotelRepository.GetHotelByIdAsync(id);

        public async Task AddHotelAsync(Hotel hotel) => await _hotelRepository.AddHotelAsync(hotel);

        public async Task UpdateHotelAsync(Hotel hotel) => await _hotelRepository.UpdateHotelAsync(hotel);

        public async Task DeleteHotelAsync(int id) => await _hotelRepository.DeleteHotelAsync(id);
    }
}
