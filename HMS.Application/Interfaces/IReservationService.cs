using HMS.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Interfaces
{
    public interface IReservationService
    {
        Task<IEnumerable<ReservationDto>> GetReservationsAsync();
        Task<ReservationDto> GetReservationByIdAsync(int id);
        Task<ReservationDto> CreateReservationAsync(ReservationDto reservationDto);
        Task<bool> UpdateReservationAsync(int id, ReservationDto reservationDto);
        Task<bool> CancelReservationAsync(int id);
    }
}
