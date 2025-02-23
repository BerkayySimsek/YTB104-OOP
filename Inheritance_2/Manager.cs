using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2
{
    internal class Manager : Employee
    {
        public int TeamCount { get; set; }

        public override string ToString()
        {
            return $"Adı : {Name}, Soyadı : {Surname}, Maaşı : {Salary}, E-mail : {Email}, Ünvanı : {Title}, Takım Sayısı : {TeamCount}";
        }
    }
}
