namespace API.Errors
{
    public class ApiExceprion : ApiResponse
    {
        public ApiExceprion(int statusCode, string? message = null , string? details = null) : base(statusCode, message)
        {
            Details = details ;
        }
        public string Details { get; set; }
    }
}