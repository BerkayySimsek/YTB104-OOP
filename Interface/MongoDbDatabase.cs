using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interface
{
    internal class MongoDbDatabase : IDatabase
    {
        public void Add(Patient patient)
        {
            Console.WriteLine($"Hasta MongoDb veritabanına eklendi.");
            Console.WriteLine(patient);
        }

        public void Delete(Patient patient)
        {
            Console.WriteLine($"Hasta MongoDb veritabanından silindi.");
            Console.WriteLine(patient);
        }

        public void GetAll()
        {
            Console.WriteLine("Tüm hastalar MongoDb veritabanından getirildi.");
        }

        public void GetByName(string Name)
        {
            Console.WriteLine("Hasta MongoDb veritabanından getirildi." + Name);
        }

        public void Update(Patient patient)
        {
            Console.WriteLine($"Hasta MongoDb veritabanından güncellendi.");
            Console.WriteLine(patient);
        }
    }
}
