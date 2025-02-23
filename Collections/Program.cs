using System.Collections;
using System.Threading.Channels;



//Array.ForEach(sehirler, x => Console.WriteLine(x));

//Listeler tip güvenli listeler oluşturmak için kullanılır.
// <> jenerik argüman

//string[] sehirler = { "Malatya", "Tunceli", "Sivas", "Erzurum", "Kars", "Elazığ", "Bingöl", "Erzincan" };

//List<string> cities = new List<string> { "Malatya", "Tunceli", "Sivas", "Erzurum", "Kars", "Elazığ", "Bingöl", "Erzincan" };


//// ArrayList : Tip güvenli olmayan liste.

//ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, "Selamlar", "132", true, false };
//foreach (object list in arrayList)
//{
//    Console.WriteLine(list);
//}

List<User> users = new List<User>()
{
    new User{Name="Berkay",Surname="Şimşek"},
    new User{Name="Ahmet",Surname="Aksakal"},
    new User{Name="Ömer",Surname="Doğan"},
    new User{Name="Ali",Surname="Veli"}
};

foreach (User user in users)
{
    Console.WriteLine(user);
}
//Console.WriteLine("Dizi işlemleri");
//foreach (string sehir in sehirler)
//{
//    Console.WriteLine(sehir);
//}

//cities.Add("İstanbul");
//cities.Remove("Kars");

//Console.WriteLine("Listeler işlemleri");
//foreach (string city in cities)
//{
//    Console.WriteLine(city);
//}
List<Product> product = new List<Product>()
{
     new Product{ Name = "Kalem", Stock=10, Price=20},
     new Product{ Name = "Defter", Stock=20, Price=30},
     new Product{ Name = "Silgi", Stock=100, Price=15},
     new Product{ Name = "Çanta", Stock=6, Price=250} 
};

foreach (Product urun in product)
{
    Console.WriteLine(urun);
}




class User
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public override string ToString()
    {
        return $"Kullanıcı Adı: {Name}, Kullanıcı Soyadı {Surname}";
    }
}


// Product : Name, Stock, Price
// Ürünler listesi oluşturup, ekran çıktısı veriniz.


class Product
{
    public string? Name { get; set; }
    public int Stock { get; set; }
    public double Price { get; set; }

    public override string ToString()
    {
        return $"Ürünün Adı: {Name}, Ürünün Stok Adedi:{Stock}, Ürünün Fiyatı: {Price}";
    }
}