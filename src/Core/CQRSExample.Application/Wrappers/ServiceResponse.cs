namespace CQRSExample.Application.Wrappers;

public class ServiceResponse<T> : BaseResponse
{
    public T Value { get; set; }


    public ServiceResponse(T value)
    {
        Value = value;
    }
    public ServiceResponse()
    {

    }
}