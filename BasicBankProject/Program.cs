/*
 Kullanıcının bakiye sorgulama, para çekme ve para yatırma işlemlerini yapabileceği bir ATM simülasyonu oluşturun.
Para çekme işlemlerinde bakiye kontrolü yapın.
Kullanıcı yanlış giriş yaparsa 3 hak verin, 3 kez yanlış giriş yaparsa hesabı bloke edin.
 */


User user = new User(2323);
Atm atm = new Atm(2000, user);
atm.GirisYap();


class Atm
{
    public Atm(decimal initialBalance, User user)
    {
        balance = initialBalance;
        kullanıcı = user;
    }

    decimal balance;
    int girisHakki = 3;
    User kullanıcı;

    public void GirisYap()
    {
        if (girisHakki > 0)
        {
            Console.WriteLine("Şifrenizi girin: ");
            int sifre = Convert.ToInt32(Console.ReadLine());

            if (kullanıcı.SifreDogrula(sifre))
            {
                Menu();
                return;
            }
            else
            {
                girisHakki--;
                Console.WriteLine($"Hatalı şifre! Lütfen şifrenizi kontrol ediniz. \nKalan deneme sayısı: {girisHakki}");
                GirisYap();
            }
        }
        else
        {
            Console.WriteLine("Şifrenizi 3 kez yanlış girdiniz. Hesabınız bloke oldu!");
        }
    }
    private void Menu()
    {
        Console.Clear();
        Console.WriteLine("Hoşgeldiniz! Lütfen Yapmak İstediğiniz İşlemi Seçiniz.");
        Console.WriteLine("1. Bakiye Sorgula");
        Console.WriteLine("2. Para Çek");
        Console.WriteLine("3. Para Yatır");
        Console.WriteLine("4. Şifre Değiştir");
        Console.WriteLine("5. Çıkış");
        Console.Write("Seçiminiz: ");

        int secim = Convert.ToInt32(Console.ReadLine());

        switch (secim)
        {
            case 1:
                Console.Clear();
                BakiyeSorgula();
                break;
            case 2:
                Console.Clear();
                ParaCek();
                break;
            case 3:
                Console.Clear();
                ParaYatır();
                break;
            case 4:
                Console.Clear();
                SifreDegistir();
                break;
            case 5:
                Console.WriteLine("Çıkış yapılıyor...");
                break;
            default:
                Console.Clear();
                Console.WriteLine("Lütfen doğru bir seçim yapınız!");
                Menu();
                break;
        }
    }
    private void SifreDegistir()
    {
        Console.Write("Mevcut şifrenizi giriniz: ");
        int mevcutSifre = Convert.ToInt32(Console.ReadLine());


        if (kullanıcı.SifreDogrula(mevcutSifre))
        { 
            kullanıcı.SifreDegistir();
            TamamMıDevamMı();
        }
        else
        {
            Console.WriteLine("Mevcut şifrenizi hatalı tuşladınız. Çıkış Yapılacak!");
        }
    }
    private void ParaYatır()
    {
        IslemTutari("Para Yatırmak");
    }
    private void ParaCek()
    {
        IslemTutari("Para Çekmek");
    }
    private void BakiyeSorgula()
    {
        Console.WriteLine($"Mecvut Bakiyeniz: {balance}");
        TamamMıDevamMı();
    }
    private void IslemTutari(string IslemTuru)
    {
        decimal tutar;
        Console.WriteLine($"{IslemTuru} için tutar giriniz:");
        if (IslemTuru == "Para Yatırmak")
        {
            tutar = Convert.ToDecimal(Console.ReadLine());
            if (tutar > 0)
            {
                balance += tutar;
                Console.WriteLine("Para yatırma işlemi başarılı.");
                TamamMıDevamMı();
            }
            else
            {
                Console.WriteLine("Hatalı işlem.");
                ParaYatır();
            }
        }
        if (IslemTuru == "Para Çekmek")
        {
            tutar = Convert.ToDecimal(Console.ReadLine());
            if (tutar <= balance && tutar > 0)
            {
                balance -= tutar;
                Console.WriteLine($"Para çekme işlemi başarılı. Mevcut bakiye: {balance}");
                TamamMıDevamMı();
            }
            else
            {
                Console.WriteLine("İşlem başarısız! Lütfen çekmek istediğiniz tutarı kontrol ediniz.");
                ParaCek();
            }
        }
    }
    private void TamamMıDevamMı()
    {
        Console.WriteLine("Başka bir işlem yapmak için menüye dönmek ister misiniz? \n1-Evet\n2-Hayır");
        int secim = Convert.ToInt32(Console.ReadLine());
        if (secim == 1)
        {
            Console.Clear();
            Menu();
        }
        else if (secim == 2)
        {
            Console.WriteLine("Çıkış yapılıyor.");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Lütfen doğru seçim yapınız.");
            TamamMıDevamMı();
        }
    }
}
class User
{
    public int sifre { get; set; }

    public User(int password)
    {
        sifre = password;
    }
    public void SifreDegistir()
    {
        Console.Write("Yeni şifrenizi girin: ");
        string? yeniSifre = Console.ReadLine();
        Console.Write("Yeni şifrenizi tekrar girin: ");
        string? yeniSifreTekrar = Console.ReadLine();

        if (yeniSifre == yeniSifreTekrar)
        {
            if (yeniSifre?.ToString().Length >= 4 && yeniSifre.All(char.IsDigit))
            {
                sifre = Convert.ToInt32(yeniSifre);
                Console.WriteLine("Şifre değiştirme başarılı.");
            }
            else
            {
                Console.WriteLine("Şifre minimum 4 rakamdan oluşmalıdır.");
                SifreDegistir();
            }
        }
        else
        {
            Console.WriteLine("Şifreler eşleşmiyor! Tekrar giriniz.");
            SifreDegistir();
        }
    }
    public bool SifreDogrula(int girilenSifre)
    {
        return girilenSifre == sifre;
    }
}