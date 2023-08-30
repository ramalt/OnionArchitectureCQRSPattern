namespace CQRSExample.Application.Wrappers;

public class PagedResponse<T> : ServiceResponse<T>
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }

    public PagedResponse(T value) : base(value)
    {
    }

    public PagedResponse(int pageNumber, int pageSize) : base()
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
    }
    public PagedResponse()
    {
        PageNumber = 1;
        PageSize = 10;
    }
}