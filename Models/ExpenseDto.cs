using System.ComponentModel.DataAnnotations;

namespace CodingChallengeTx.Models
{
    /// <summary>
    ///  The expense dto model.
    /// </summary>
    public class ExpenseDto
    {

        [Required]
        public DateTime? Date { get; set; }

        [Required]
        [StringLength(100)]
        public string? TypeOfExpense { get; set; }

        [Required]
        [Range(typeof(decimal), "0", "999999999999.99")]
        public decimal? Amount { get; set; }

        [Required]
        [StringLength(3)]
        public string? CurrencyCode { get; set; }

        [StringLength(500)]
        public string? Remarks { get; set; }
    }

}
