

try
{
    Console.WriteLine("Birinci sayıyı girin :");
    double sayi1 = Convert.ToDouble(Console.ReadLine());
    //if (sayi1.GetType() != typeof(double))
    //{
    //    Console.WriteLine("Yanlış karakter girdiniz.");
    //}

    Console.WriteLine("İkinci sayıyı girin :");
    double sayi2 = Convert.ToDouble(Console.ReadLine());

    if (sayi2 == 0)
    {
        throw new Exception("Bölen kısım 0 olamaz.");
    }

    double sonuc = sayi1 / sayi2;
    Console.WriteLine(sonuc);
}

catch(FormatException)
{
    Console.WriteLine("Girmiş olduğunuz sayı düzgün formatta değil.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}




