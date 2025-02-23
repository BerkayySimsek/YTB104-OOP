using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Fruit
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Season { get; set; }
        public override string ToString()
        {
            return $"Meyvenin Adı: {Name},Meyvenin Fiyatı: {Price},Meyvenin Stoğu: {Stock},Meyvenin Mevsimi {Season}";
        }
    }
}
