using AutoMapper;
using Marketplace.Models;

namespace Marketplace.DTO
{
    public class Mapper : Profile
    {
        public Mapper() {
            CreateMap<Product, CardProductDto>();
            CreateMap<CardProductDto, Product>();


        } 

    }
}
