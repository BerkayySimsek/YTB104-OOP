//Console.WriteLine("Lütfen adınızı giriniz: ");
//string name = Console.ReadLine();

//Console.WriteLine("Lütfen soyadınızı giriniz: ");
//string surName = Console.ReadLine();

//Console.WriteLine("Adınız: " + name + " " + "Soyadınız: " + surName);

Console.WriteLine("Lütfen 1-7 arasında bir sayı giriniz.");
int day = Convert.ToInt32(Console.ReadLine());

string dayName = "";
//if (day == 1)
//{
//    dayName = "Pazartesi";
//}
//else if (day == 2)
//{
//    dayName = "Salı";
//}
//else if (day == 3)
//{
//    dayName = "Çarşamba";
//}
//else if (day == 4)
//{
//    dayName = "Perşembe";
//}
//else if (day == 5)
//{
//    dayName = "Cuma";
//}
//else if (day == 6)
//{
//    dayName = "Cumartesi";
//}
//else if (day == 7)
//{
//    dayName = "Pazar";
//}
//else
//{
//    Console.WriteLine("Lütfen değer aralığını aşmayınız.");
//}

//switch (day)
//{
//    case 1:
//        dayName = "Pazartesi";
//        break;
//    case 2:
//        dayName = "Salı";
//        break;
//    case 3:
//        dayName = "Çarşamba";
//        break;
//    case 4:
//        dayName = "Perşembe";
//        break;
//    case 5:
//        dayName = "Cuma";
//        break;
//    case 6:
//        dayName = "Cumartesi";
//        break;
//    case 7:
//        dayName = "Pazar";
//        break;
//    default:
//        dayName = "Lütfen 1 ile 7 arasında bir sayı giriniz.";
//        break;
//}
//Console.WriteLine(dayName);

//switch expression

string result = day switch
{
    1 => "Pazartesi",
    2 => "Salı",
    3 => "Çarşamba",
    4 => "Perşembe",
    5 => "Cuma",
    6 => "Cumartesi",
    7 => "Pazar",
    _ => "Geçersiz karakter."
};
Console.WriteLine(result);


/* Hesap mak.
Console.WriteLine("**************************************BASİT HESAP MAKİNESİ**************************************");
Console.WriteLine("1- Toplama İşlemi");
Console.WriteLine("2- Çıkarmaİşlemi");
Console.WriteLine("3- Çarpma İşlemi");
Console.WriteLine("4- Bölme İşlemi");
Console.WriteLine("Hangi işlemi yapmak istiyorsunuz? Lütfen sayı olarak belirtin:");
int secim = Convert.ToInt32(Console.ReadLine());
int sayi1;
int sayi2;

if (secim == 1)
{
    Console.WriteLine("Toplama İşlemi");
    Console.WriteLine("Lütfen bir sayı giriniz:");
    sayi1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Lütfen bir sayı daha giriniz:");
    sayi2 = Convert.ToInt32(Console.ReadLine());
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Sonuç:" + sonuc);
}
else if (secim == 2)
{
    Console.WriteLine("Çıkarma İşlemi");
    Console.WriteLine("Lütfen bir sayı giriniz:");
    sayi1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Lütfen bir sayı daha giriniz:");
    sayi2 = Convert.ToInt32(Console.ReadLine());
    int sonuc = sayi1 - sayi2;
    Console.WriteLine("Sonuç:" + sonuc);
}
else if (secim == 3)
{
    Console.WriteLine("Çarpma İşlemi");
    Console.WriteLine("Lütfen bir sayı giriniz:");
    sayi1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Lütfen bir sayı daha giriniz:");
    sayi2 = Convert.ToInt32(Console.ReadLine());
    int sonuc = sayi1 * sayi2;
    Console.WriteLine("Sonuç:" + sonuc);
}
else if (secim == 4)
{
    Console.WriteLine("Bölme İşlemi");
    Console.WriteLine("Lütfen bir sayı giriniz:");
    sayi1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Lütfen bir sayı daha giriniz:");
    sayi2 = Convert.ToInt32(Console.ReadLine());
    int sonuc = sayi1 / sayi2;
    Console.WriteLine("Sonuç:" + sonuc);
}
else
{
    Console.WriteLine("Lütfen doğru bir değer giriniz.");
}
*/

