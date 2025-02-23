using System.Reflection.Metadata.Ecma335;

namespace Encapsulation;
// Erişim bildirgeçleri
// public -> Her yerden erişilebilir
// private -> sadece kullanıldığı class içinden erişimi olan yapılardır.

public class User
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
        set { }
    }
    public string? Password { get; set; }

    //public void SetFirstName(string text)
    //{
    //    Firstname = text;
    //}
    //public void SetLastName(string text)
    //{
    //    Lastname = text;
    //}
    ////public void SetFullName(string text)
    ////{
    ////    Fullname = text;
    ////}
    //public void SetPassword(string text)
    //{
    //    Password = text;
    //}
    //public string GetFirstName()
    //{
    //    return Firstname;
    //}
    //public string GetLastName()
    //{
    //    return Lastname;
    //}
    //public string GetFullName()
    //{
    //    return $"{Firstname} {Lastname}";
    //}
    //public string GetPassword()
    //{
    //    return Password;
    //}

    public override string ToString()
    {
        return $"Kullanıcı Tam Adı : {FullName}, Parola : {Password}";
    }
}
