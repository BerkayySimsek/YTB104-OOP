namespace Inheritance
{
    internal class Motorcyle:Vehicle
    {
        
        public bool HasStand {  get; set; }

        public override string ToString()
        {
            return $"Model : {Model}, Marka : {Brand}, Hız : {Speed}, Vites : {TransmissionType}, Renk : {Color} , Yakıt Tipi : {FuelType} , Ayaklık Var Mı : {HasStand}";
        }
    }
}
