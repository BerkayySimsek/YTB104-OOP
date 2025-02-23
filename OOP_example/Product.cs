
namespace OOP_example;

public class Product
{
    public string? Name { get; set; }
    public double? Price { get; set; }
    public int? Stock { get; set; }
    public string? CategoryName { get; set; }

    public override string ToString()
    {
        return $"Adı: {Name}, Ürün Fiyatı {Price}, Stok: {Stock}, Kategorisi: {CategoryName}";
    }
}
