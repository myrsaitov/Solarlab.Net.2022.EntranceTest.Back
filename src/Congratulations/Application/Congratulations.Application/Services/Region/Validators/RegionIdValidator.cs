using FluentValidation;

namespace Sev1.Congratulations.AppServices.Services.Congratulation.Validators
{
    /// <summary>
    /// Валидатор Id объявления
    /// </summary>
    public class RegionIdValidator : AbstractValidator<int?>
    {
        public RegionIdValidator()
        {
            // Проверка Id
            RuleFor(x => x)
                .NotNull()
                .NotEmpty().WithMessage("CongratulationId is null!")
                .InclusiveBetween(1, int.MaxValue);
        }
    }
}