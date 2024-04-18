namespace CodingChallengeTx.Models
{
    /// <summary>
    ///  The validation result model.
    /// </summary>
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public List<string> Errors { get; set; }
    }
}
