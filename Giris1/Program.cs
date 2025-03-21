﻿// numbers adında bir dizimiz olsun ve for döngüsüyle teker teker bütün sayıları gezerken 
// {1,3,4,5,7,8,6,11,44,34}
// Tek sayı: 3,
// Çift sayı: 6
Console.WriteLine("--------------Case Çözümü--------------");

int[] sayiDizisi = { 1, 3, 4, 5, 7, 8, 6, 11, 44, 34 };
for (int i = 0; i < sayiDizisi.Length; i++)
{

    if (i % 2 == 0)
    {
        Console.WriteLine($"Çift sayı: {i}");
    }
    else
    {
        Console.WriteLine($"Tek sayı: {i}");
    }
}

//string: metinsel ifadelere karşılık gelen veri tipidir.
//int (Integer): Tam sayılara karşılık gelen veri tipidir.
//double: ondalıklı ve tam sayılara karşılık gelen veri tipidir.
double boy = 1.75;
//bool: doğruluk değeri taşır sadece true veya false değerlerini alır.
bool dogru = true;
bool yanlis = false;


// -----------OPERATÖRLER-----------
Console.WriteLine("**************************Aritmetik Operatörler*************************");

// Aritmetik Operatörler: + - / * %

// 10/3= 3.3333333
Console.WriteLine(10 % 3);

string? ad = "Berkay";
string? soyad = "Şimşek";

string adSoyad = ad + " " + soyad;
Console.WriteLine(adSoyad);
Console.WriteLine("**************************Karşılaştırma Operatörleri*************************");

// Karşılaştırma Operatörüleri: < , > , <= , >= , == !=

Console.WriteLine(3 < 5);       //true
Console.WriteLine(3 <= 3);      //true
Console.WriteLine(35 >= 46);    //false
Console.WriteLine(88 != 88);    //false
Console.WriteLine(9 == 9);      //true
Console.WriteLine("**************************Mantıksal Operatörler*************************");
// Mantıksal Operatörler: && -> ve , || -> veya , ! -> değil

Console.WriteLine((4 == 5) || (3 > 2));
//                   0    veya   1       =1
Console.WriteLine((4 == 5) && (3 > 2));
//                   0    ve     1       =0
Console.WriteLine(!(4 == 5) && (3 > 2));
//                   1           1       =1


int age = 15;
bool okuma_yazma = true;

if (age >= 18 && okuma_yazma == true)
{
    Console.WriteLine("Ehliyet alabilirsiniz.");
}
else
{
    Console.WriteLine("Ehliyet alamazsınız.");
}

int num1 = 20;
int num2 = 25;

string islem = "+";

if (islem == "+")
{
    Console.WriteLine(num1 + num2);
}
else if (islem == "-")
{
    Console.WriteLine(num1 - num2);
}
else if (islem == "/")
{
    Console.WriteLine(num1 / num2);
}
else
{
    Console.WriteLine(num1 * num2);
}

Console.WriteLine("----------------------------------CASE----------------------------------");
int not = 95;

// not değeri 50 - 60(d) arasında ise D
// not değeri 60 - 70(d) arasında ise C
// not değeri 70 - 80(d) arasında ise B
// not değeri 80 - 90(d) arasında ise A
// not değeri 90 - 100(d) arasında ise S
// not değeri 50 altı ise F
// Bunun dışında alınan her değer için 0 - 100 arasında bir puan giriniz.
if (not < 0 || not > 100)
{
    Console.WriteLine("0 ile 100 arasında bir değer giriniz.");
}
else if (not < 50)
{
    Console.WriteLine("Kaldınız: F");
}

if (not >= 50 && not <= 60)
{
    Console.WriteLine("Notunuz: D");
}
else if (not > 60 && not <= 70)
{
    Console.WriteLine("Notunuz: C");
}
else if (not > 70 && not <= 80)
{
    Console.WriteLine("Notunuz: B");
}
else if (not > 80 && not <= 90)
{
    Console.WriteLine("Notunuz: A");
}
else if (not > 90 && not <= 100)
{
    Console.WriteLine("Notunuz: S");
}