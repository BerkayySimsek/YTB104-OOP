// Kullanıcı giriş yapmak istiyor ilgili kişi yoksa dizide ekran çıktısı olarak kulanıcı bulunamadı desin.
// Kullanıcı bulunduysa bir parola doğrulaması yapılması gerekmektedir.

using System.Reflection.Metadata.Ecma335;

User user = new User
{
    Name = "Berkay",
    Surname = "Şimşek",
    City = "Elazığ",
    Email = "berkayysimsekk@gmail.com",
    Password = "Password123"
};
User user1 = new User
{
    Name = "Ahmet",
    Surname = "Aksakal",
    City = "Ankara",
    Email = "aksakalahmet@gmail.com",
    Password = "123456"
};

User[] users = {user, user1,new User()
{
    Name="Ömer Faruk",
    Surname="Doğan",
    City="Malatya",
    Email="qubitFaruk@gmail.com",
    Password="Password1234"}
};



User loginUser = GetUserInfo();
Login(loginUser);

// null gelme
// sadece boşluk
// ""

void Login(User user)
{
    // validasyon kuralları
    if (string.IsNullOrWhiteSpace(user.Email)|| string.IsNullOrWhiteSpace(user.Password))
    {
        Console.WriteLine("İlgili alanlar boş olamaz.");
        return;
    }

    if (user.Email.EndsWith("@gmail.com")==false)
    {
        Console.WriteLine("Email alanı düzgün formatta değil.");
        return;
    }

    if (user.Password.Length<6)
    {
        Console.WriteLine("Parola alanı minimum 6 haneli olmalıdır.");
    }

    int count = 0;

    // Flag yöntemi
    bool isTrue = false;

    foreach (User person in users)
    {
        if (person.Email == user.Email)
        {
            count++;

            if (person.Password == user.Password)
            {
                isTrue = true;
            }
            break;
        }
    }
    if (isTrue == false)
    {
        Console.WriteLine("Parola yanlış!");
    }
    if (count == 0)
    {
        Console.WriteLine("Böyle bir kullanıcı mevcut değildir.");
    }
    if (isTrue == true && count == 1)
    {
        Console.WriteLine("Giriş Başarılı");
    }
}

User GetUserInfo()
{
    //Console.WriteLine("Lütfen İsim yazınız: ");
    //string name = Console.ReadLine();

    //Console.WriteLine("Lütfen Soyisim yazınız: ");
    //string surName = Console.ReadLine();

    //Console.WriteLine("Lütfen Şehir yazınız: ");
    //string city = Console.ReadLine();

    Console.WriteLine("Lütfen Email yazınız: ");
    string email = Console.ReadLine();

    Console.WriteLine("Lütfen Parola yazınız: ");
    string password = Console.ReadLine();

    User u = new User()
    {
        //Name = name,
        //Surname = surName,
        //City = city,
        Email = email,
        Password = password,
    };

    return u;
}

class User
{
    public string Name;
    public string Surname;
    public string Email;
    public string Password;
    public string City;
}