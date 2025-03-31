using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IHotelRepository Hotels { get; }
        IRoomRepository Rooms { get; }
        IReservationRepository Reservations { get; }
        Task<int> SaveChangesAsync();
    }
}
