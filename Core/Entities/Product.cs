namespace Core.Entities;

public class Product : BaseEntity
{
    public string? Name { get; set; } 
    public string? Description { get; set; }
    public decimal Price {get; set;}
    public string? ImageUrl { get; set; }
    public Category? Category { get; set; }
    public int CategoryId { get; set; }
    public ProductBrand? ProductBrand { get; set; } 
    public int ProductBrandId { get; set; }
    public ICollection<Review>? Reviews { get; set; }
}
