

Araba araba = new Araba()
{
    Marka = "Toyota",
    Model = "Corolla",
    Fiyat = 1250000
};

Araba araba1 = new Araba();
araba1.Marka = "BMW";
araba1.Model = "M5";
araba1.Fiyat = 3000000;

//Console.WriteLine(araba);


ArabaManager manager = new ArabaManager();

Araba alinanAraba = manager.GetAraba();
manager.Ekle(alinanAraba);

class Araba
{
    public string? Model { get; set; }
    public string? Marka { get; set; }
    public double? Fiyat { get; set; }

    public override string ToString()
    {
        return $"Arabanın; Markası: {Marka}, Modeli: {Model}, Fiyatı: {Fiyat}";
    }
}

class ArabaManager
{
    // Araba Modeli boş olamaz.
    // Araba Markası boş olamaz.
    // Araba Fiyatı negatif değer alamaz.
    public void Ekle(Araba araba)
    {
        if (string.IsNullOrWhiteSpace(araba.Marka))
        {
            Console.WriteLine("Araba Markası boş olamaz.");
            return;
        }
        if (string.IsNullOrWhiteSpace(araba.Model))
        {
            Console.WriteLine("Araba Markası boş olamaz.");
            return;
        }

        if (araba.Fiyat<0)
        {
            Console.WriteLine("Araba fiyatı negatif değer olamaz.");
            return;
        }
        Console.WriteLine($"Araba eklendi {araba}");
    }

    public Araba GetAraba()
    {
        Console.WriteLine("Lütfen araba markası giriniz:");
        string? marka=Console.ReadLine();
        Console.WriteLine("Lütfen araba modeli giriniz:");
        string? model=Console.ReadLine();
        Console.WriteLine("Lütfen araba fiyatını giriniz:");
        double fiyat=Convert.ToDouble(Console.ReadLine());

        Araba araba = new Araba()
        {
            Marka = marka,
            Model = model,
            Fiyat = fiyat
        };
        return araba;
    }
}