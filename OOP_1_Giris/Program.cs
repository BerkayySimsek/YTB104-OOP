
// class tanımladıktan sonra, kullanım aşamasında: Class_adı değişken_adı = new Class_adı();

//Product product = new Product()
//{
//    Name = "TBRUSH Beyazlatıcı ve Diş Silgisi",
//    CategoryName = "Kozmetik",
//    Description = "Açıklama metni",
//    Price = 150.09
//};
//product.EkranaYaz();

//Console.WriteLine("----------------------------------------------------------------------");

//Product product1 = new Product()
//{
//    Name = "Vorch Unisex Sweatshirt",
//    CategoryName = "Giyim",
//    Description = "Açıklama metni",
//    Price = 539.10
//};

//product1.EkranaYaz();
//Console.WriteLine("------------------------------------------------------------------------");
//Category category = new Category()
//{
//    Name = "Kozmetik",
//    Description = "Kişisel Bakım Ürünleri",
//};
//category.EkranaYaz();

int[] sayilar = { 1, 2, 3, 4, 5, };
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
};

// oluşturduğumuz class'lar referans tiplidir. Referans tipli veriler new anahtar sözcüğü ile oluşturulur.



class Product
{
    // Özellikler
    public string Name;
    public string Description;
    public string CategoryName;
    public double Price;

    // Fonksiyonlar : 
    public void EkranaYaz()
    {
        Console.WriteLine($"Ürünün adı: {Name}");
        Console.WriteLine($"Ürünün Kategori adı: {CategoryName}");
        Console.WriteLine($"Ürünün Açıklaması: {Description}");
        Console.WriteLine($"Ürünün Fiyatı: {Price}");

    }
}

// Category adında bir class oluşturun. string Name, string Description alanları olsun
// Ekrana yaz fonksiyonunu olşturunuz.

class Category
{
    public string Name;
    public string Description;

    public void EkranaYaz()
    {
        Console.WriteLine($"Kategori Adı: {Name}");
        Console.WriteLine($"Kategori Açıklaması: {Description}");
    }
}
