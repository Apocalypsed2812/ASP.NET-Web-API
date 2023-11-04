using FluentValidation;
using TikiAPI.Models;

namespace TikiAPI.Validator
{
    public class CategoryValidator : AbstractValidator<CategoryModel>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is not empty");
        }
    }
}
