using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance;

internal class Car:Vehicle
{
    
    public byte DoorNumber { get; set; }

    public override string ToString()
    {
        return $"Model : {Model}, Marka : {Brand}, Hız : {Speed}, Vites : {TransmissionType}, Renk : {Color} , Yakıt Tipi : {FuelType} , Kapı Sayısı : {DoorNumber}";
    }
}
