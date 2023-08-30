using CQRSExample.Domain.Entities;

namespace CQRSExample.Application.Interfaces.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        
    }
}