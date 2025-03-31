using HMS.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Validations
{
    public class ReservationValidator : AbstractValidator<ReservationDto>
    {
        public ReservationValidator()
        {
            RuleFor(r => r.CheckInDate).GreaterThan(DateTime.Now).WithMessage("Check-in date must be in the future.");
            RuleFor(r => r.CheckOutDate).GreaterThan(r => r.CheckInDate).WithMessage("Check-out date must be after check-in date.");
        }
    }
}
