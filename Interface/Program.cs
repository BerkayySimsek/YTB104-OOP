// interface : C# ta sözleşme gibi davranan yapılara interface denir.
using Interface;

// Şirkette 2 tane veritabanı olduğunu düşünelim ve bu veri tabanlarının hepsinde CRUD(Create - Read - Update - Delete) operasyonları mevcuttur. Sistem şuan MSSQL'de çalışırken ilerleyen zamanlarda MongoDB alternatifi de eklenmesi isteniyor. Sistemi kurgulayınız.

// Hastane Bilişim Yönetim Sistemi üzerinde çalışan bir program. 
// Ve bu sistemde Hasta Ekleme Silme Güncelleme ve Listeleme operasyonlarının olduğunu düşünelim.

// Sonrasında şirket Excell e de CRUD operasyonlarını istedi.

// Bütün veritabanlarına isme göre arama özelliğini getiriniz. 

Patient patient = new Patient("Semih Tarhan", "Dudak", 19);

MsSqlDatabase msSqlDatabase = new MsSqlDatabase();
MongoDbDatabase mongoDbDatabase = new MongoDbDatabase();
ExcelDatabase excelDatabase = new ExcelDatabase();

Console.WriteLine("Hastayı hangi veritabanına eklemek istersiniz?");
Console.WriteLine("1 -> MsSql");
Console.WriteLine("2 -> MongoDb");
Console.WriteLine("3 -> Excel");

int db = Convert.ToInt32(Console.ReadLine());

if (db == 1)
{
    msSqlDatabase.Add(patient);
    msSqlDatabase.GetByName("Semih Tarhan");
}
else if (db == 2)
{
    mongoDbDatabase.Add(patient);
    mongoDbDatabase.GetByName("Semih Tarhan");
}
else if (db == 3)
{
    excelDatabase.Add(patient);
    excelDatabase.GetByName("Semih Tarhan");
}