namespace CQRSExample.Application.Parameters
{
    public class RequestParameter
    {
        public int PageSize { get; private set; }
        public int PageNumber { get; private set; }

        public RequestParameter(int pageSize, int pageNumber)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }


    }
}