using CQRSExample.Application.Interfaces.Repository;
using CQRSExample.Domain.Entities;
using CQRSExample.Persistence.Data;

namespace CQRSExample.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext): base(dbContext)
        {
            
        }
    }
}