using System.ComponentModel.DataAnnotations;

namespace Comarch20230523.Shared.Validators
{
    public class PasswordValidation : ValidationAttribute
    {
        private readonly int minLenght;
        private readonly int maxLength;
        private readonly bool requireDigit;
        private readonly bool requireLowerCase;
        private readonly bool requireUpperCase;
        private readonly bool requireNonAlphanumeric;

        public PasswordValidation(int minLenght, int maxLength, bool requireDigit, bool requireLowerCase,
            bool requireUpperCase, bool requireNonAlphanumeric)
        {
            this.minLenght = minLenght;
            this.maxLength = maxLength;
            this.requireDigit = requireDigit;
            this.requireLowerCase = requireLowerCase;
            this.requireUpperCase = requireUpperCase;
            this.requireNonAlphanumeric = requireNonAlphanumeric;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string password = value as string;
            string message = null;

            if (string.IsNullOrWhiteSpace(password))
            {
                message = "Hasło nie może być puste.";
                ErrorMessage = message;
                return new ValidationResult(message);
            }

            if (password.Length < minLenght || password.Length > maxLength)
            {
                message = $"Hasło nie może być krótsze niż {minLenght} lub dłuższe niż {maxLength}";
                ErrorMessage = message;
                return new ValidationResult(message);
            }

            return ValidationResult.Success;
        }
    }
}
