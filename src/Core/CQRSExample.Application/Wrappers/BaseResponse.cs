namespace CQRSExample.Application.Wrappers
{
    public class BaseResponse
    {
        public Guid Id { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; }
    }
}