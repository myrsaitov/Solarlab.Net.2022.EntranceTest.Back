using FluentValidation;

namespace Sev1.Congratulations.AppServices.Services.Congratulation.Validators
{
    /// <summary>
    /// Валидатор Id объявления
    /// </summary>
    public class CongratulationIdValidator : AbstractValidator<int?>
    {
        public CongratulationIdValidator()
        {
            // Проверка Id
            RuleFor(x => x)
                .NotNull()
                .NotEmpty().WithMessage("CongratulationId is null!")
                .InclusiveBetween(1, int.MaxValue);
        }
    }
}