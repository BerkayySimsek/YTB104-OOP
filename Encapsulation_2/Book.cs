namespace Encapsulation_2;

// Kullanıcıdan yazar adı ve soyadı alındıktan sonra Fullname diye bir alan oluştur. Ekrana çıktıyı ver.
// Yazarın adı ve soyadı kısmı sadece yazılabilir olsun okunabilir olmasın.


// Kullanıcı fiyat bilgisini girdikten sonra %20 KDV uygulasın.


// private
// public
public class Book
{
    private double _price;
    public string? Title { get; set; }
    public string? ISBN { get; set; }

    // 1. Yöntem

    //public double Price
    //{
    //    get
    //    {
    //        return _price;
    //    }
    //    set
    //    {
    //        _price = value * 1.20;
    //    }
    //}

    public double Price
    {
        get => _price;

        set => _price = value * 1.20;
    }

    public string? AuthorFirstName { private get; set; }
    public string? AuthorSurName { private get; set; }
    //public string? AuthorFullName
    //{
    //    //get
    //    //{
    //    //    return $"{AuthorFirstName} {AuthorSurName}";
    //    //}

    //    get => $"{AuthorFirstName} {AuthorSurName}";
    //}

    public string? AuthorFullName => $"{AuthorFirstName} {AuthorSurName}";


    //public override string ToString()
    //{
    //    return $"Kitabın başlığı : {Title}, Isbn numarası : {ISBN}, Fiyatı : {Price}, Yazarı : {AuthorFullName}";
    //}

}
