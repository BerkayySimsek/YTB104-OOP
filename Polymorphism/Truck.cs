using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance;

internal class Truck : Vehicle
{
    
    public double Capacity { get; set; }

    public override string ToString()
    {
        return $"Model : {Model}, Marka : {Brand}, Hız : {Speed}, Vites : {TransmissionType}, Renk : {Color} , Yakıt Tipi : {FuelType} , Yük Kapasitesi : {Capacity}";
    }
}
