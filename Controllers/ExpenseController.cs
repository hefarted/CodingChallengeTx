using CodingChallengeTx.Interfaces;
using CodingChallengeTx.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingChallengeTx.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseService _expenseService;

        public ExpenseController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        [HttpGet("HelloWorld")]
        public IActionResult GetHelloWorld()
        {
            return Ok("Hello, world!");
        }

        [HttpPost("InterfaceAP")]
        public IActionResult PostExpense([FromBody] ExpenseDto expense)
        {
            var result = _expenseService.ProcessExpense(expense);
            if (!result)
            {
                var validation = _expenseService.ValidateExpense(expense);
                return BadRequest($"Error: {string.Join(", ", validation.Errors)}");
            }

            return Ok("OK");
        }
    }

}
