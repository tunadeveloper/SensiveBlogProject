using FluentValidation;
using SensiveBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlogProject.BusinessLayer.ValidationRules.CategoryValidationRules
{
   public class CreateCategoryValidator : AbstractValidator<Category>
    {
        public CreateCategoryValidator() {

            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Minimum 3 Harf giriniz.");
        }
    }
}
