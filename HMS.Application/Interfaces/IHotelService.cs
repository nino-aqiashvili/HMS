using HMS.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Interfaces
{
    public interface IHotelService
    {
        Task<IEnumerable<HotelDto>> GetAllHotelsAsync();
        Task<HotelDto> GetHotelByIdAsync(int id);
        Task AddHotelAsync(HotelDto hotelDto);
        Task UpdateHotelAsync(int id, HotelDto hotelDto);
        Task DeleteHotelAsync(int id);
    }
}
