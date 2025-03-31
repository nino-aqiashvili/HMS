using HMS.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Validations
{
    public class HotelValidator : AbstractValidator<HotelDto>
    {
        public HotelValidator()
        {
            RuleFor(h => h.Name).NotEmpty().WithMessage("Hotel name is required.");
            RuleFor(h => h.Rating).InclusiveBetween(1, 5).WithMessage("Rating must be between 1 and 5.");
        }
    }
}
