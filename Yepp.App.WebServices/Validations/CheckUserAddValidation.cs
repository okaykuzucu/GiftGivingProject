using FluentValidation;
using Yepp.App.Services.Models;

namespace Yepp.App.WebServices.Validations
{
    public class CheckUserAddValidation : AbstractValidator<UserAddOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckUserAddValidation"/> class.
        /// </summary>
        public CheckUserAddValidation()
        {
            RuleFor(x => x.Email).EmailAddress().WithMessage("mail adresiniz geçersiz.");
            RuleFor(x => x.Name).NotNull().MinimumLength(2).WithMessage("adınızı yazınız");
            RuleFor(x => x.SurName).NotNull().MinimumLength(2).WithMessage("soyadınızı yazınız");
            RuleFor(x => x.Telephone).NotNull().MinimumLength(6).WithMessage("telefonunuzu yazınız");
            RuleFor(x => x.Language).NotNull().MinimumLength(2).WithMessage("dilinizi seçiniz");
            RuleFor(x => x.Password).NotNull().MinimumLength(6).WithMessage("şifrenizi yazınız");



        }
    }
}
