using Inheritance;

Vehicle car = new Car()
{
    Brand = "Audi",
    Color = "Siyah",
    DoorNumber = 4,
    FuelType = "Benzin",
    Model = "A6",
    Speed = 240,
    TransmissionType = "Otomatik"
};

Vehicle motor = new Motorcyle()
{
    Brand = "Yamaha",
    Color = "Mavi",
    FuelType = "Benzin",
    Model = "R25",
    Speed = 175,
    TransmissionType = "Manuel",
    HasStand = true,
};




Console.WriteLine(car);
Console.WriteLine(motor);
