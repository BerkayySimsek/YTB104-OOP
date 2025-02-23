using Inheritance;

Truck truck = new Truck()
{
    Brand = "Volvo",
    Model = "FH540",
    Capacity = 10,
    Color = "Ekru",
    FuelType = "Benzin",
    Speed = 150,
    TransmissionType = "Manuel"
};

Car car = new Car()
{
    Brand = "Volvo",
    Model = "S60",
    Color = "Siyah",
    FuelType = "Elektrikli",
    Speed = 240,
    TransmissionType = "Otomatik",
    DoorNumber=4
};

Motorcyle motorcyle = new Motorcyle()
{
    Brand = "Yamaha",
    Model = "MT07ABS",
    Color = "Gece Mavisi",
    FuelType = "Benzin",
    Speed = 280,
    TransmissionType = "Yarı Otomatik",
    HasStand=true,
};

Console.WriteLine(car);
Console.WriteLine(truck);
Console.WriteLine(motorcyle);