


Yemek yemek = new Yemek()
{
    Name = "Çiğ Köfte",
    Type = "Ana Yemek"
};

Yemek yemek1 = new Yemek("Analı Kızlı", "Ana Yemek");

Console.WriteLine(yemek1);

Console.WriteLine(yemek);



class Yemek
{
    public Yemek()
    {
        Console.WriteLine("Constructor Blok çalıştı.");
    }
    public Yemek(string name,string type)
    {
        Name = name;
        Type = type;
    }
    public string Name { get; set; }
    public string Type { get; set; }

    public override string ToString()
    {
        return $"Adı : {Name}, Tipi : {Type}";
    }
}