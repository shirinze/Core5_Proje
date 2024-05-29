using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuinessLayer.ValidationRules
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("project name can not be empty");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("project name should be minimum 5 characters");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("project name should be maximum 100 characters");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("image url can not be empty");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("image url2 can not be empty");
            RuleFor(x => x.Price).NotEmpty().WithMessage("price can not be empty");
            RuleFor(x => x.Value).NotEmpty().WithMessage("value can not be empty");
            
        }
    }
}
