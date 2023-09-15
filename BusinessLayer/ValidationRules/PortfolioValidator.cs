using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        //ctor
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje Adi Bos Gecilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Bos Gecilemez");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Resim Bos Gecilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat Bos Gecilemez");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Deger Bos Gecilemez");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje Adi En Az 5 Karakter Olmalidir");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Proje Adi En Fazla 100 Karakter Olmalidir");
        }
    }
}
