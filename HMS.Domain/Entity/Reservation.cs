using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Entity
{
    using System;

    namespace HMS.Domain.Entity
    {
        public class Reservation
        {
            public int Id { get; set; }
            public DateTime CheckIn { get; set; }
            public DateTime CheckOut { get; set; }

            public int RoomId { get; set; }
            public Room Room { get; set; } = null!; // დარწმუნდით, რომ Room კლასიც არის არსებულ პროექტში

            public int GuestId { get; set; }
            public Guest Guest { get; set; } = null!; // დარწმუნდით, რომ Guest კლასიც არის არსებულ პროექტში
        }
    }

}
