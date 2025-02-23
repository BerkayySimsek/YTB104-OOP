using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_2
{
    public class Product
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return $"Ürün Adı: {Name}, Ürün Adedi {Stock}, Ürün Fiyatı: {Price}";
        }
    }
}
