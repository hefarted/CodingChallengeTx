
using CodingChallengeTx.Models;

namespace CodingChallengeTx.Interfaces
{
    /// <summary>
    ///  The interface expensive service.
    /// </summary>
    public interface IExpenseService
    {
        ValidationResult ValidateExpense(ExpenseDto expense);
        bool ProcessExpense(ExpenseDto expense);
    }
}
