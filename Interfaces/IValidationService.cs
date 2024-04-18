using CodingChallengeTx.Models;

namespace CodingChallengeTx.Interfaces
{
    /// <summary>
    ///  The interface validation service.
    /// </summary>
    public interface IValidationService
    {
        ValidationResult ValidateExpense(ExpenseDto expense);
    }
}
