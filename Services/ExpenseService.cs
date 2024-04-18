using CodingChallengeTx.Interfaces;
using CodingChallengeTx.Models;

namespace CodingChallengeTx.Services
{
    /// <summary>
    ///  The expense service.
    /// </summary>
    public class ExpenseService : IExpenseService
    {
        private readonly IValidationService _validationService;

        public ExpenseService(IValidationService validationService)
        {
            _validationService = validationService;
        }

        public ValidationResult ValidateExpense(ExpenseDto expense)
        {
            return _validationService.ValidateExpense(expense);
        }

        public bool ProcessExpense(ExpenseDto expense)
        {
            var validationResult = ValidateExpense(expense);
            if (!validationResult.IsValid)
            {
                return false;
            }
            // I can put some database process here.

            return true;
        }
    }
}
