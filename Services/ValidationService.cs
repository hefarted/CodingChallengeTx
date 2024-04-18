
using CodingChallengeTx.Interfaces;
using CodingChallengeTx.Models;

namespace CodingChallengeTx.Services
{
    /// <summary>
    ///  The validation service class.
    /// </summary>
    public class ValidationService : IValidationService
    {
        private static readonly string[] ValidCurrencies = new[] { "USD", "EUR", "GBP", "PHP" };

        public ValidationResult ValidateExpense(ExpenseDto expense)
        {
            var errors = new List<string>();

            if (!ValidCurrencies.Contains(expense.CurrencyCode))
            {
                errors.Add("Invalid currency code.");
            }

            if (expense.Date < DateTime.UtcNow.AddYears(-1) || expense.Date > DateTime.UtcNow)
            {
                errors.Add("Date must be within the last year and not in the future.");
            }

            return new ValidationResult
            {
                IsValid = !errors.Any(),
                Errors = errors
            };
        }
    }
}
