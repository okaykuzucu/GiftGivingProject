using FluentValidation;
using Yepp.App.WebServices.Dtos;

namespace Yepp.App.WebServices.Validations
{
    /// <summary>
    /// The Email Validator
    /// </summary>
    /// <seealso cref="FluentValidation.AbstractValidator{Yepp.App.WebServices.Dtos.ForgotPasswordDto}" />
    public class CheckMailValidation : AbstractValidator<ForgotPasswordDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckMailValidation"/> class.
        /// </summary>
        public CheckMailValidation()
        {
            RuleFor(x => x.Email).EmailAddress().WithMessage("mail adresiniz geçersiz.");
        }
    }
}
