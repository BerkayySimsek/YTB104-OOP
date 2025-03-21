﻿namespace OOP_example;

public class ProductController
{
    ProductManager manager = new ProductManager();

    public void Islemler()
    {
        Dictionary<int, string> islemler = new Dictionary<int, string>();
        islemler.Add(1, "Ürünleri Listele");
        islemler.Add(2, "isme Göre Filtrele");
        islemler.Add(3, "Kategoriye Göre Filtrele");
        islemler.Add(4, "Ürün Fiyat Aralığına Göre Filtrele");
        islemler.Add(5, "Stokta Olmayan Ürünleri Listele");

        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.");

        foreach (KeyValuePair<int, string> islem in islemler)
        {
            Console.WriteLine($"İşlem no: {islem.Key}, İşlem : {islem.Value}");
        }

        Console.WriteLine("İşlem numarasını giriniz : ");
        int islemNo = Convert.ToInt32(Console.ReadLine());

        if (islemNo == 1)
        {
            manager.UrunListele();
        }
        else if (islemNo == 2)
        {
            manager.UrunIsmineGoreListele();
        }
        else if (islemNo == 3)
        {
            manager.KategoriyeGoreUrunListele();
        }
        else if (islemNo == 4)
        {
            manager.FiyatAraliginaGoreUrunListele();
        }
        else if (islemNo == 5)
        {
            manager.StoklariBitenUrunleriListele();
        }
    }


    public void Run()
    {

        Console.WriteLine("Menüyü görmek ister misiniz? (e: evet, h: hayır)");
        string devam = Console.ReadLine();

        Console.Clear();

        while (true)
        {
            if (devam == "e")
            {
                Islemler();

                Console.WriteLine("İşleme devam etmek ister misiniz? (e: evet, h: hayır)");
                devam = Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Çıkış Yapılıyor.");
                break;
            }
        }
    }
}