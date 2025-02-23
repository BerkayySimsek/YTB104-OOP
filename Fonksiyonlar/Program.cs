// f(x)=x+5
// f(1)=1+5=6
// f(20)=20+5=25
// g(x,y)=x/y
// fonksiyon oluşturma: dönüş_tipi fonksiyon_adı(parametre_tipi değişkeni,parametre_tipi değişkeni)

//değer döndüren
//değer döndürmeyen

//parametreli
//parametresiz
//DRY - Don't Repeat Yourself

double sonuc = Carpma(40, 20);
Console.WriteLine(sonuc);

Console.WriteLine(Bolme(25, 60));

string metin1 = Info("Berkay", "Şimşek", ".Net", 100);
string metin2 = Info("Cansu", "Akil", "Coğrafya", 100);
string metin3 = Info("Ahmet", "Aksakal", "Biyoloji", 60);
string metin4 = Info("Mehmet", "Aslan", "Matematik", 45);

string metin5 = InfoAndAverage("Berkay", "Şimşek", ".Net", 100, 85, 92);
string metin6 = InfoAndAverage("Cansu", "Akil", "Coğrafya", 100, 95, 95);
string metin7 = InfoAndAverage("Ahmet", "Aksakal", "Biyoloji", 60, 40, 55);
string metin8 = InfoAndAverage("Mehmet", "Aslan", "Matematik", 45, 30, 20);
string metin9 = InfoAndAverage("Can", "Tost", "Türkçe", 145, 300, 120);

Console.WriteLine("+++++++++++++++++++++++++++++++BİLGİLER++++++++++++++++++++++++++++++++++++++");
Console.WriteLine(metin1);
Console.WriteLine(metin2);
Console.WriteLine(metin3);
Console.WriteLine(metin4);
Console.WriteLine("+++++++++++++++++++++++++++++++ORTALAMALAR++++++++++++++++++++++++++++++++++++++");
Console.WriteLine(metin5);
Console.WriteLine(metin6);
Console.WriteLine(metin7);
Console.WriteLine(metin8);
Console.WriteLine(metin9);

//değer döndüren parametreli fonksiyon:

double Toplama(double sayi1, double sayi2)
{
    return sayi1 + sayi2;
}

double Cikarma(double sayi1, double sayi2)
{
    return sayi1 - sayi2;
}

double Carpma(double sayi1, double sayi2)
{
    return sayi1 * sayi2;
}

double Bolme(double sayi1, double sayi2)
{
    return sayi1 / sayi2;
}

//Öğrencinin adı , soyadı , dersi , notu bir metin olarak veren bir fonksiyon
string Info(string name, string surname, string lesson, double note)
{
    string metin = $"Öğrenci adı : {name}, Öğrenci Soyadı: {surname}, Dersi: {lesson}, Puan: {note}";
    return metin;
}

//Ortalama Hesabı ve Bilgileri yazan parça fonksiyonlar.
double Average(double s1, double s2, double s3)
{
    return (s1 + s2 + s3) / 3;
}

string InfoMessage(string name,string surname,string lesson,double average,string letterPoint)
{
    return $"Öğrencinin adı: {name}, Soyadı {surname}, Dersi {lesson}, Ortalama {average}, {letterPoint}";
}

// not ortalamasını alsın sonrasında öğrenci bilgileriyle beraber bir metinsel ifadede göster
string InfoAndAverage(string name, string surname, string lesson, double note1, double note2, double note3)
{
    double average = Average(note1,note2,note3);
    string mesaj = "";
    if (average < 50)
    {
        mesaj = InfoMessage(name,surname,lesson,average,"Kaldınız (F)");
    }
    else if (average >= 50 && average < 65)
    {
        mesaj = InfoMessage(name,surname,lesson,average,"Geçtiniz (D)");
    }
    else if (average >= 65 && average < 75)
    {
        mesaj = InfoMessage(name, surname, lesson, average, "Geçtiniz (C)");
    }
    else if (average >= 75 && average < 85)
    {
        mesaj = InfoMessage(name, surname, lesson, average, "Geçtiniz (B)");

    }
    else if (average >= 85 && average <= 100)
    {
        mesaj = InfoMessage(name, surname, lesson, average, "Geçtiniz (A)");

    }
    else
    {
        mesaj = "Girmiş olduğunuz notlar 0 ile 100 arasında olmalıdır.";
    }
    return mesaj;
}