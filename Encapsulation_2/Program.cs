
using Encapsulation_2;

Book book = new Book
{
    AuthorFirstName = "Sait",
    AuthorSurName = "Faik",
    Title = "Abasıyanık",
    Price = 350,
    ISBN = "9783127323207"
};

Console.WriteLine(book);

Category category = new Category("Polisiye", "Polisiye Açıklaması");

Category category1 = new Category("Polisiye", "Polisiye Açıklaması");

Category category2 = category1 with { Name = "Dram" };
Console.WriteLine(category2);

bool esitMi = category == category1;


//category.Name = "Dram";
//category.Description = "Deneme";

Console.WriteLine(esitMi);
Console.WriteLine(category);