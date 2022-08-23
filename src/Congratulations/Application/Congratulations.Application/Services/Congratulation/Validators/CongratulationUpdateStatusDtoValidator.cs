using FluentValidation;
using Sev1.Congratulations.AppServices.Contracts.Congratulation.Requests;
using Sev1.Congratulations.AppServices.Services.Tag.Validators;
using Sev1.Congratulations.Domain.Base.Validators;

namespace Sev1.Congratulations.AppServices.Services.Congratulation.Validators
{
    /// <summary>
    /// Валидатор DTO при обновлении объявления
    /// </summary>
    public class CongratulationUpdateStatusDtoValidator : NullReferenceAbstractValidator<CongratulationUpdateStatusRequest>
    {
        public CongratulationUpdateStatusDtoValidator()
        {
            // Общая проверка
            RuleFor(x => x)
                .NotNull()
                .NotEmpty().WithMessage("CongratulationUpdateDto is null!");

            // Статус объявления
            RuleFor(x => x.Status)
                .NotNull().WithMessage("Status не заполнен!");
        }
    }
}