using HMS.Application.DTOs;
using HMS.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Services
{
    public class RoomService : IRoomService
    {
        public Task<IEnumerable<RoomDto>> GetRoomsByHotelIdAsync(int hotelId) => throw new NotImplementedException();
        public Task<RoomDto> GetRoomByIdAsync(int hotelId, int roomId) => throw new NotImplementedException();
        public Task<RoomDto> CreateRoomAsync(RoomDto roomDto) => throw new NotImplementedException();
        public Task<bool> UpdateRoomAsync(int id, RoomDto roomDto) => throw new NotImplementedException();
        public Task<bool> DeleteRoomAsync(int id) => throw new NotImplementedException();
    }

}
