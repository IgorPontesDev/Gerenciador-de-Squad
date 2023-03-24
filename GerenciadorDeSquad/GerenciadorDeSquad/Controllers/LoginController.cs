using GerenciadorDeSquad.Models;
using GerenciadorDeSquad.Validator;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;
using FluentValidation.Results;

namespace GerenciadorDeSquad.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();

            UserValidator validator = new UserValidator();
            ValidationResult results = validator.Validate(user);

            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                    Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was:" + failure.ErrorMessage);
            }                          
            

            return View("Index", user);
        }
        [HttpPost]
        public IActionResult Test(UserViewModel user)
        {            
            user.Email = "email enviado";
            return View("Index", user);
        }
    }
}
