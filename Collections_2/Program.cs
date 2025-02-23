using Collections_2;
using System.Diagnostics;
using System.Xml.Linq;
using System.Xml.Serialization;

List<Product> products = new List<Product>()
{
    new Product{Name="Dyson Süpürge",Price=25000,Stock=250 },
    new Product{Name="Prada Çanta",Price=50000,Stock=120 },
    new Product{Name="Roborock Robot Süpürge",Price=35000,Stock=25 },
};

products.Add(new Product { Name = "Philips Süpürge", Price = 14000, Stock = 25 });
CokluElemanEkle(products);
ElemanCikar(products, "D");
ListeEkranaYaz(products);

Console.WriteLine("--------------------------------------------------------------");

ElemanVarMi(products, "Dyson Süpürge");

GetAllProductByPriceRange(products, 100, 1500);

Console.WriteLine("---------------------------------------------------------");
GetAllProductPricesSum(products);
GetAllProductsAverage(products);



void ListeEkranaYaz(List<Product> products)
{
    //foreach (Product product in products)
    //{
    //    Console.WriteLine(product);
    //}

    // lambda expression
    products.ForEach(p => Console.WriteLine(p));
}

void CokluElemanEkle(List<Product> products)
{
    List<Product> added = new List<Product>()
    {
        new Product{Price=50,Name="A",Stock=14},
        new Product{Price=250,Name="B",Stock=140},
        new Product{Price=1250,Name="C",Stock=36},
        new Product{Price=2250,Name="D",Stock=47},
    };
    products.AddRange(added);
}

void ElemanCikar(List<Product> products, string name)
{
    foreach (Product p in products)
    {
        if (p.Name == name)
        {
            products.Remove(p);
            break;
        }
    }
}

void ElemanVarMi(List<Product> products, string name)
{
    // Geleneksel Yöntem
    // Flag Yöntemi

    bool isPresent = false;
    // 1. Yöntem
    //foreach (Product p in products)
    //{
    //    if (p.Name==name)
    //    {
    //        isPresent = true;
    //        break;
    //    }
    //}

    // 2. Yöntem
    // Exists : İLGİLİ eleman varsa true, yoksa false değerini döner. Lambda şeklinde yazılan yapı doğruluk değer taşımalıdır.
    isPresent = products.Exists(p => p.Name == name);


    // 1. Yöntem
    //if (isPresent==false)
    //{
    //    Console.WriteLine("Aradığınız ürün bulunamadı.");
    //}
    //else
    //{
    //    Console.WriteLine("Aradığınız ürün bulundu.");
    //}
    // 2. Yöntem
    string metin = isPresent == true ? "Aradığınız ürün bulundu." : "Aradığınız ürün bulunamadı.";
    Console.WriteLine(metin);
}

void GetAllProductByPriceRange(List<Product> urunler, double min, double max)
{
    Console.WriteLine($"--------------------------------ÜRÜN FİLTRELEME : {min}-{max}--------------------------------");

    // 1. Yöntem
    List<Product> filteredProducts = new List<Product>();

    //foreach (Product product in urunler)
    //{
    //    if (product.Price <= max && product.Price >= min)
    //    {
    //        filteredProducts.Add(product);
    //    }
    //}

    // 2. Yöntem
    // FindAll : filtreleme işlemleri için kullanılır. Lambda bir doğruluk değeri taşıman zorundadır.
    filteredProducts = urunler.FindAll(product => product.Price <= max && product.Price >= min);

    ListeEkranaYaz(filteredProducts);
}

void GetAllProductPricesSum(List<Product> products)
{
    double total = 0;

    //foreach (Product p in products)
    //{
    //    //total = total + p.Price;

    //    total += p.Price;
    //}

    //Console.WriteLine($"Ürünlerin fiyatları toplamı: {total}");



    // Sum : listedeki tüm elamanların belirli alanlarına göre toplama yapar.
    // Lambda alanı liste içerisindeki gezmiş olduğu her elemanın belirli bir alanı için çalışır.

    total = products.Sum(x => x.Price);
    Console.WriteLine($"Ürünlerin fiyatları toplamı: {total}");
}

void GetAllProductsAverage(List<Product> urunler)
{
    // 1500 , 2500 , 3000
    // ortalama = (1500+2500+3000) / 3 = 2333

    double average = 0;
    double total = 0;

    // 1. Yöntem

    //foreach (Product p in urunler)
    //{
    //    total += p.Price;
    //}
    //average = total / urunler.Count;

    average=urunler.Average(x => x.Price);

    Console.WriteLine($"Ürünlerin ortalaması: {average}");
}