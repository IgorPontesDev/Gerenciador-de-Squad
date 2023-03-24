using FluentValidation;
using GerenciadorDeSquad.Models;

namespace GerenciadorDeSquad.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator() {
            RuleFor(user => user.Email).NotNull().WithMessage("Email vazio");
            RuleFor(user => user.Email).EmailAddress().WithMessage("Email invalido");
            RuleFor(user => user.Password).NotNull().WithMessage("Digite a senha");
        }  
    }
}
