using Marketplace.Models;

namespace Marketplace.DTO
{   
    public class UserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
    }
    public class CardProductDto {
        public int Id { get; set; }
        public string Title { get; set; }        
        public float Price { get; set; }
        public float Rating { get; set; }
       // public ICollection<ProductCategory> ProductCategories { get; set; }
       


    }
}
