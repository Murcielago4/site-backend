using Marketplace.DTO;

namespace Marketplace.Interfaces
{
    public interface IProductService
    {
        public Task<IEnumerable<CardProductDto>> GetAllCardsAsync();

    }
}
