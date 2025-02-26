using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class Vehicle
    {
        public string? Model { get; set; }
        public string? Brand { get; set; }
        public double? Speed { get; set; }
        public string? FuelType { get; set; }
        public string? TransmissionType { get; set; }
        public string? Color { get; set; }
    }
}
