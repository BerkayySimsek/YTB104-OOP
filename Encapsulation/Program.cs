

// Kullanıcıdan ilgili alanları alarak ekran çıktısını verin.

using Encapsulation;

User user = new User()
{
    FirstName = "Berkay",
    LastName = "Şimşek",
    Password = "Password123."
};
Console.WriteLine(user);
//Console.WriteLine($"Kullanıcının tam adı : {user.GetFullName()}");


Product product = new Product()
{
    Name = "Asus Rog Strix",
    Price = 65000,
    Stock = 250
};
Console.WriteLine(product);

Book book = new Book()
{
    AuthorName = "name",
    AuthorSurname = "surname",
    Description = "Description",
    Title = "Title",
    Price = 125,
};
Console.WriteLine(book);
