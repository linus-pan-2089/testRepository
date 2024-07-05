using System.ComponentModel.DataAnnotations;

public class Product
{
    [Key]
    public int IdProduct { get; set; }
    public string ProductCode { get; set; } = string.Empty;
    public string ProductType { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal UnitPrice { get; set; }
    public int QtyInStock { get; set; }
}
