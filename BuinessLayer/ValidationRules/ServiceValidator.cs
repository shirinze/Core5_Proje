using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuinessLayer.ValidationRules
{
    public class ServiceValidator:AbstractValidator<Service>
    {
        public ServiceValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("title can not be empty");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Image can not be empty");
            
        }
    }
}
