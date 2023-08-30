using CQRSExample.Application.Wrappers;
using MediatR;

namespace CQRSExample.Application.Features.Commands.Product;

public class AddProductCommand : IRequest<ServiceResponse<Guid>>
{
    public string Name { get; set; }
    public decimal Value { get; set; }
    public int Quantity { get; set; }
}