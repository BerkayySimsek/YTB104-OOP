using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2
{
    internal class Programmer: Employee
    {
        public string ProgrammingLanguage  { get; set; }

        public override string ToString()
        {
            return $"Adı : {Name}, Soyadı : {Surname}, Maaşı : {Salary}, E-mail : {Email}, Ünvanı : {Title}, Programlama dili : {ProgrammingLanguage}";
        }
    }
}
