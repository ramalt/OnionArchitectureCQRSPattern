using AutoMapper;
using CQRSExample.Application.Dto;
using CQRSExample.Application.Interfaces.Repository;
using CQRSExample.Application.Wrappers;
using MediatR;

namespace CQRSExample.Application.Features.Queries.Product;

public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, ServiceResponse<List<ProductDto>>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetAllProductsQueryHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ServiceResponse<List<ProductDto>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        var products = await _productRepository.GetAllAsync();

        // var dto = products.Select(x => new ProductDto
        // {
        //     Id = x.Id,
        //     Name = x.Name,
        // }).ToList();

        var mapped = _mapper.Map<List<ProductDto>>(products);

        return new ServiceResponse<List<ProductDto>>(mapped);
    }
}

