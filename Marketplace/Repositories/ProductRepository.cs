using Marketplace.Interfaces;
using Marketplace.Models;

namespace Marketplace.Repositories
{
    public class ProductRepository: GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context) {  }

    }
}
