using AutoMapper;
using Marketplace.DTO;
using Marketplace.Interfaces;


namespace Marketplace.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRep;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRep, IMapper mapper) { 
        
        _productRep = productRep;
        _mapper = mapper;
        }

        public async Task<IEnumerable<CardProductDto>> GetAllCardsAsync() {
            var cards = await _productRep.GetAllAsync();
            return _mapper.Map<IEnumerable<CardProductDto>>(cards);
        }
    }
}
