using FluentValidation;
using TikiAPI.Models;

namespace TikiAPI.Validator
{
    public class HobbyValidator : AbstractValidator<HobbyModel>
    {
        public HobbyValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
