using HMS.Application.DTOs;
using HMS.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Services
{
    public class ReservationService : IReservationService
    {
        public Task<IEnumerable<ReservationDto>> GetReservationsAsync() => throw new NotImplementedException();
        public Task<ReservationDto> GetReservationByIdAsync(int id) => throw new NotImplementedException();
        public Task<ReservationDto> CreateReservationAsync(ReservationDto reservationDto) => throw new NotImplementedException();
        public Task<bool> UpdateReservationAsync(int id, ReservationDto reservationDto) => throw new NotImplementedException();
        public Task<bool> CancelReservationAsync(int id) => throw new NotImplementedException();
    }
}
