using HMS.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Validations
{
    public class RoomValidator : AbstractValidator<RoomDto>
    {
        public RoomValidator()
        {
            RuleFor(r => r.Name).NotEmpty().WithMessage("Room name is required.");
            RuleFor(r => r.Price).GreaterThan(0).WithMessage("Price must be greater than zero.");
        }
    }
}
