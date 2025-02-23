using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Detail
    {
        public string? StudentName { get; set; }
        public double Average { get; set; }

        public override string ToString()
        {
            return $"Öğrenci Adı: {StudentName}, Ortalama: {Average}";
        }

    }
}
