using CQRSExample.Application.Dto;
using CQRSExample.Application.Wrappers;
using MediatR;

namespace CQRSExample.Application.Features.Queries.Product;

public class GetAllProductsQuery : IRequest<ServiceResponse<List<ProductDto>>>
{

}