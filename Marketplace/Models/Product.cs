namespace Marketplace.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }
        public float Rating { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
    public class ProductCategory
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
    public class Category {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }

    }
}
