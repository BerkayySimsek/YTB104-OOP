Computer pc = new Computer()
{
    ekran_karti = "Nvidia rtx 4090 ti",
    marka = "MSI",
    ram = 32,
    tipi = "Laptop",
    renk = "Siyah"
};
Console.WriteLine($"Bilgisayarın markası: {pc.marka}");
Console.WriteLine($"Bilgisayarın tipi: {pc.tipi}");
Console.WriteLine($"Bilgisayarın rami: {pc.ram}");
Console.WriteLine($"Bilgisayarın rengi: {pc.renk}");
Console.WriteLine($"Bilgisayarın ekran kartı: {pc.ekran_karti}");
Console.WriteLine(pc);


int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
//                0  1  2  3  4  5  6  7  8  9
Console.WriteLine(sayilar);

for (int i = 0; i < sayilar.Length; i++)
{
    Console.WriteLine(sayilar[i]);
}

class Computer
{
    public string? ekran_karti;
    public int ram;
    public string? marka;
    public string? tipi;
    public string? renk;
}