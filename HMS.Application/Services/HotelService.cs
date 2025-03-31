using HMS.Application.DTOs;
using HMS.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Services
{
    public class HotelService : IHotelService
    {
        public Task<IEnumerable<HotelDto>> GetAllHotelsAsync() => throw new NotImplementedException();
        public Task<HotelDto> GetHotelByIdAsync(int id) => throw new NotImplementedException();
        public Task<HotelDto> CreateHotelAsync(HotelDto hotelDto) => throw new NotImplementedException();
        public Task<bool> UpdateHotelAsync(int id, HotelDto hotelDto) => throw new NotImplementedException();
        public Task<bool> DeleteHotelAsync(int id) => throw new NotImplementedException();
    }
}
