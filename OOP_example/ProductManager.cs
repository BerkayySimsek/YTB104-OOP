﻿namespace OOP_example;

public class ProductManager
{
    ProductData data = new ProductData();

    public void UrunListele()
    {
        Console.WriteLine("Ürünler Listelendi.");
        List<Product> products = data.GetAll();

        products.ForEach(x => Console.WriteLine(x));

        DetayYazdir(products);
    }

    public void KategoriyeGoreUrunListele()
    {
        Console.WriteLine("Lütfen Kategori Adını Giriniz: ");
        string category = Console.ReadLine();

        List<Product> filteredProducts = data.GetAllByCategory(category);
        Console.WriteLine($"{category} kategorisine ait ürünler");

        filteredProducts.ForEach(x => Console.WriteLine(x));

        DetayYazdir(filteredProducts);
    }
    public void FiyatAraliginaGoreUrunListele()
    {
        Console.WriteLine("Lütfen ürünün minimum değerini giriniz: ");
        double min = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Lütfen ürünün maksimum değerini giriniz: ");
        double max = Convert.ToDouble(Console.ReadLine());

        List<Product> filtered = data.GetAllByPriceRange(min, max);
        Console.WriteLine($"{min} TL - {max} TL arasındaki ürünler");
        filtered.ForEach(x => Console.WriteLine(x));

        DetayYazdir(filtered);
    }

    public void UrunIsmineGoreListele()
    {
        Console.WriteLine("Lütfen aramak istediğiniz metni giriniz.");
        string text = Console.ReadLine();

        List<Product> filtered = data.GetAllByNameContains(text);
        Console.WriteLine($"İsminde {text} geçen ürünler: ");
        filtered.ForEach(x => Console.WriteLine(x));
        DetayYazdir(filtered);
    }

    public void StoklariBitenUrunleriListele()
    {
        Console.WriteLine("Stokları biten ürünlerin Listesi :");
        List<Product> filtered = data.GetAllStockFinished();

        filtered.ForEach(x => Console.WriteLine(x));
        DetayYazdir(filtered);

    }
    void DetayYazdir(List<Product> products)
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Ürünler ve Detayları");
        Console.WriteLine($"Ürün Sayısı: {products.Count} ");
        Console.WriteLine($"Ürünlerin Fiyat Toplamı: {products.Sum(x => x.Price)}");
        Console.WriteLine($"Ürünlerin Fiyat Ortalaması: {products.Average(x => x.Price)}");
        Console.WriteLine($"En ucuz ürün => {products.MinBy(x => x.Price)}");
        Console.WriteLine($"En pahalı ürün => {products.MaxBy(x => x.Price)}");
        Console.WriteLine($"En çok stoklu ürün => {products.MaxBy(x=>x.Stock)}");
        Console.WriteLine($"En az stoklu ürün => {products.Where(x => x.Stock>0).MinBy(x=>x.Stock)}");
    }
}
