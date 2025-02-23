namespace Interface;

public class ExcelDatabase : IDatabase
{
    public void Add(Patient patient)
    {
        Console.WriteLine($"Hasta Excel veritabanına eklendi.");
        Console.WriteLine(patient);
    }

    public void Delete(Patient patient)
    {
        Console.WriteLine($"Hasta Excel veritabanından silindi.");
        Console.WriteLine(patient);
    }

    public void GetAll()
    {
        Console.WriteLine("Tüm hastalar Excel veritabanından getirildi.");
    }

    public void GetByName(string Name)
    {
        Console.WriteLine("Hasta Excel veritabanından getirildi." + Name);
    }

    public void Update(Patient patient)
    {
        Console.WriteLine($"Hasta Excel veritabanından güncellendi.");
        Console.WriteLine(patient);
    }
}
