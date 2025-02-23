using System.Collections.Generic;
using System.Threading.Channels;

List<Ogrenci> ogrenciler = new List<Ogrenci>
{
    new Ogrenci { Ad = "Ali", Soyad = "Yılmaz", Not = 85 },
    new Ogrenci { Ad = "Ayşe", Soyad = "Kara", Not = 92 },
    new Ogrenci { Ad = "Mehmet", Soyad = "Demir", Not = 76 },
    new Ogrenci { Ad = "Zeynep", Soyad = "Çelik", Not = 89 },
    new Ogrenci { Ad = "Burak", Soyad = "Öztürk", Not = 60 }
};
Case10();




// todo: Notu 80 den fazla olan öğrencilerin ekran çıktısı
void Case1()
{
    ogrenciler.Where(x => x.Not > 80).ToList().ForEach(c => Console.WriteLine(c));
}

// todo: Öğrencileri notlarına göre büyükten küçüğe sırala
void Case2()
{
    ogrenciler.OrderByDescending(x => x.Not).ToList().ForEach(c => Console.WriteLine(c));
}

// todo: Ortalama notu hesapla 
void Case3()
{
    double ortalamaNot = ogrenciler.Average(x => x.Not);
    Console.WriteLine($"Ortalama Not : {ortalamaNot}");
}

// todo: En yüksek notu alan öğrenci
void Case4()
{
    var EnYuksekNotuAlanOgrenci = ogrenciler.OrderByDescending(x => x.Not).First();
    Console.WriteLine($"En yüksek notu alan öğrenci: {EnYuksekNotuAlanOgrenci}");
}

// todo: Sınıftaki en yüksek ve en düşük not arasındaki farkı bul
void Case5()
{
    int enDusukNot = ogrenciler.Min(x => x.Not);
    int enYuksekNot = ogrenciler.Max(x => x.Not);

    int notFarki = enYuksekNot - enDusukNot;
    Console.WriteLine($"En yüksek ve en düşük not arasındaki fark : {notFarki}");
}

// todo: Sınıfta 50’nin altında not alan kaç öğrenci olduğunu bul
void Case6()
{
    int ogrenciSayisi = ogrenciler.Count(x => x.Not < 50);
    Console.WriteLine(ogrenciSayisi);
}

//todo: Sınıfta belirli bir harf ile başlayan öğrencileri listele (örn: "A" harfi ile başlayanlar)
void Case7()
{
    char harf = 'A';
    var belirliHarfIleBaslayan = ogrenciler.Where(x => x.Ad.StartsWith(harf.ToString()));
    foreach (var ogrenci in belirliHarfIleBaslayan)
    {
        Console.WriteLine($"İsmi {harf} ile başlayan öğrenci : {ogrenci}");
    }
}
// todo: Not ortalamasının üzerinde not alan öğrencileri listele
void Case8()
{
    double ortalamaNot = ogrenciler.Average(x => x.Not);
    ogrenciler.Where(x => x.Not > ortalamaNot).ToList().ForEach(c => Console.WriteLine($"Ortalamanın üzerinde not alan öğrenci : {c}"));
}
// todo: Adı 5 harften kısa olan öğrencileri listele
void Case9()
{
    ogrenciler.Where(x => x.Ad?.Length < 5).ToList().ForEach(c => Console.WriteLine($"Adı 5 harften kısa olan öğrenci : {c}"));

}
//todo: Öğrenciler listesini rastgele sırala
void Case10()
{
    Random rnd= new Random();
    ogrenciler.OrderBy(x=>rnd.Next()).ToList().ForEach(c => Console.WriteLine(c));
}




class Ogrenci
{
    public string? Ad { get; set; }
    public string? Soyad { get; set; }
    public int Not { get; set; }

    public override string ToString()
    {
        return $"Ad = {Ad}, Soyad = {Soyad}, Not = {Not}";
    }
}