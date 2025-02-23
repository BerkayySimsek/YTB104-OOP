using System.Security.Principal;

namespace Encapsulation;

public class Book
{
    // Book -> Title Description Price AuthorName AuthorSurname
    // AuthorDetail alanı AuthorName ve AuthorSurname alanlarının yan yana yazılsın AuthorDetail alanı sadece okunur olmalı.
    // Price alanına kdv ekleyerek yeni fiyatı set etsin

    private double _price;
    public string? Title { get; set; }
    public string? Description { get; set; }
    public double Price
    {
        get
        {
            return _price;
        }
        set
        {
            _price = value * 1.20;
        }
    }
    public string? AuthorName { get; set; }
    public string? AuthorSurname { get; set; }
    public string? AuthorDetail
    {
        get
        {
            return $"{AuthorName} {AuthorSurname}";
        }
    }

    public override string ToString()
    {
        return $"Kitabın Yazarı : {AuthorDetail},Adı : {Title}, Açıklaması : {Description}, Fiyatı : {Price}";
    }
}
