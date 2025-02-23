namespace Encapsulation_2;


// Kategori adı bir kere değeri atandıktan sonra bir daha değişmesin.

// record: Değer karşılaştırılması yapılacak senaryolarda kullanılır.
// immutable class anlamı taşır. (Değiştirilemez)
// ToString metodunu tekrar yazmaya gerek kalmaz.
// Primary Constructor yöntemi ile veriler alınabilir.

// Dto larda çok sık kullanılır.

//1. Yöntem 

//public record Category
//{
//    public string? Name { get; init; }
//    public string? Description { get; init; }

//    //public override string ToString()
//    //{
//    //    return $"Kategori adı : {Name}, Açıklaması : {Description}";
//    //}
//}
public record Category(string? Name, string? Description);