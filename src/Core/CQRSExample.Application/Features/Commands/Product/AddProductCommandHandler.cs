using AutoMapper;
using CQRSExample.Application.Interfaces.Repository;
using CQRSExample.Application.Wrappers;
using MediatR;

namespace CQRSExample.Application.Features.Commands.Product;

public class AddProductCommandHandler : IRequestHandler<AddProductCommand, ServiceResponse<Guid>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public AddProductCommandHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ServiceResponse<Guid>> Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        var product = _mapper.Map<Domain.Entities.Product>(request);
        await _productRepository.AddAsync(product);

        return new ServiceResponse<Guid>(product.Id);
    }
}