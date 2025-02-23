namespace Encapsulation;


// Kullanıcı ürün fiyatını girdiği zaman %20 KDV değerini uygulayarak yeni değeri oluştur.
public class Product
{

    private double _price;

    public string? Name { get; set; }
    public double Price
    {
        get
        {
            return _price;
        }
        set
        {
            _price = value * 1.20;
        }
    }
    public int Stock { get; set; }

    public override string ToString()
    {
        return $"Ürünün adı : {Name}, Fiyatı {Price}, Stok adedi : {Stock}";
    }



}
