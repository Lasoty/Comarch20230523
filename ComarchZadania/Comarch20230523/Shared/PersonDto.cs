using Comarch20230523.Shared.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comarch20230523.Shared;

public class PersonDto
{
    [Required(ErrorMessage = "Nazwa użytkownika jest wymagana.")]
    public string Name { get; set; }

    [Range(18, 130, ErrorMessage = "Wiek użytkownika musi być w przedziale 18 do 130 lat.")]
    public int Age { get; set; }

    [Required(ErrorMessage = "Adres email jest wymagany.")]
    [EmailAddress(ErrorMessage = "Adres email jest nieprawidłowy")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Adres email i tak jest nieprawidłowy.")]
    public string Email { get; set; }

    [Compare(nameof(Email), ErrorMessage = "Nie potwierdziłeś adresu email.")]
    public string ConfirmEmail { get; set; }

    [Required(ErrorMessage = "Hasło jest wymagane")]
    [PasswordValidation(8, 50, false, false, false, false)]
    public string Password { get; set; }

    [Required(ErrorMessage = "Adres jest wymagany")]
    [StringLength(255, MinimumLength = 10, ErrorMessage = "Minimalna długość adresu to 10 znaków.")]
    public string Address { get; set; }
}
