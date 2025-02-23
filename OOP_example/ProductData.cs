
namespace OOP_example;

// Single Responsibility

// Filtreleme ve listeleme operasyonlarını yapıyor.
public class ProductData
{
    public List<Product> products = new List<Product>
    {
        new Product{Name="Dyson Süpürge",Price=25000,Stock=250,CategoryName="Ev Aletleri" },
        new Product{Name="Prada Çanta",Price=50000,Stock=120,CategoryName="Aksesuar" },
        new Product{Name="Roborock Robot Süpürge",Price=35000,Stock=25,CategoryName="Ev Aletleri" },
        new Product{Name="Rayban Gözlük", Price=15000,Stock=2, CategoryName = "Aksesuar"},
        new Product{Name="Dior Sauvage",Price=7000,CategoryName="Kozmetik",Stock=25},
        new Product{Name="Bez Dolap",Price=350,Stock=21,CategoryName="Ev Aletleri"},
        new Product{Name="Samsung m51",CategoryName="Teknoloji",Price=15000,Stock=34},
        new Product{Name="Samsung S22 Ultra",CategoryName="Teknoloji",Price=35000,Stock=4},
        new Product{Name="Msi Bravo 15",CategoryName="Teknoloji",Stock=14,Price=35000},
        new Product{Name="Volume Maskara",Price=224.5,Stock=0,CategoryName="Kozmetik" },
        new Product{Name="Paradoxe Virtual Flower Parfüm",Price=3800,Stock=10,CategoryName="Kozmetik" },
        new Product{Name="Onvo Televizon",Price=7263,Stock=0,CategoryName="Teknoloji" },
        new Product{Name="Apple iPad 10. Nesil",Price=14699,Stock=20,CategoryName="Teknoloji" },
        new Product{Name="Dekor Luna Avize",Price=379.9,Stock=25,CategoryName="Ev Aletleri" },
        new Product{Name="Iphone 13 Kılıf",Price=140.99,Stock=74,CategoryName="Aksesuar" },
    };

    public List<Product> GetAll()
    {
        return products;
    }
    public List<Product> GetAllByNameContains(string text)
    {
        return products.FindAll(p => p.Name.ToLower().Contains(text.ToLower()));
    }
    public List<Product> GetAllByPriceRange(double min, double max)
    {
        return products.Where(x => x.Price >= min && x.Price <= max).ToList();
    }
    public List<Product> GetAllByCategory(string categoryName)
    {
        return products.FindAll(x => x.CategoryName.ToLower() == categoryName.ToLower());
    }
    public List<Product> GetAllStockFinished()
    {
        return products.Where(x => x.Stock == 0).ToList();
    }
}
