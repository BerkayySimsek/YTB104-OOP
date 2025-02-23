
CategoriesManager kategori=new CategoriesManager();
Categories gelen = kategori.GetCategories();
kategori.Ekle(gelen);


class CategoriesManager
{
    public void Ekle(Categories categories)
    {
        if (string.IsNullOrEmpty(categories.Name))
        {
            Console.WriteLine("Kategori Adı Boş Olamaz!");
            return;
        }
        if (string.IsNullOrEmpty(categories.Description))
        {
            Console.WriteLine("Kategori Açıklaması Boş Olamaz!");
            return;
        }
        Console.WriteLine($"Kategori Eklendi. {categories}");
    }

    public Categories GetCategories()
    {
        Console.WriteLine("Kategori adı girin.");
        string? catName = Console.ReadLine();
        Console.WriteLine("Kategori açıklaması girin.");
        string? catDesc = Console.ReadLine();
        Categories categories = new Categories()
        {
            Name = catName,
            Description = catDesc
        };
        return categories;
    }
}

class Categories
{
    public string Name { get; set; }
    public string Description { get; set; }

    public override string ToString()
    {
        return $"Kategorinin Adı: {Name}, Kategorinin Açıklaması: {Description} ";
    }
}