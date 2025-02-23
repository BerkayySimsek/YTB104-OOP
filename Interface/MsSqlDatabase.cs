namespace Interface;

public class MsSqlDatabase : IDatabase
{
    public void Add(Patient patient)
    {
        Console.WriteLine($"Hasta MsSql veritabanına eklendi.");
        Console.WriteLine(patient);
    }

    public void Delete(Patient patient)
    {
        Console.WriteLine($"Hasta MsSql veritabanından silindi.");
        Console.WriteLine(patient);
    }

    public void GetAll()
    {
        Console.WriteLine("Tüm hastalar MsSql veritabanından getirildi.");
    }

    public void GetByName(string Name)
    {
        Console.WriteLine("Hasta MsSql veritabanından getirildi." + Name);
    }

    public void Update(Patient patient)
    {
        Console.WriteLine($"Hasta MsSql veritabanından güncellendi.");
        Console.WriteLine(patient);
    }
}
