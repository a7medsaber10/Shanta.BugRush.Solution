namespace Shanta.APIs.Errors
{
    public class ValidationErrorResponse : APIResponse
    {
        public IEnumerable<string> Errors { get; set; }
        public ValidationErrorResponse() : base(400)
        {
            Errors = new List<string>();
        }
    }
}
