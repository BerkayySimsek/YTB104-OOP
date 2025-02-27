

Account account = new Account()
{
    Iban = "TR430006278119285542252216",
    Name = "Berkay Şimşek",
    Incoming = 25000,
    OutGoing = 20001,

};
Console.WriteLine(account);



class Account
{

    private double _outGoing;


    public string? Iban { get; set; }
    public string? Name { get; set; }
    public double Incoming { get; set; }
    public double Total => Incoming - OutGoing;
    public double OutGoing
    {
        get => _outGoing;
        set
        {
            if (value > 1000 && value < 2000)
            {
                _outGoing = value + 4;
            }
            else if (value > 2000 && value < 10000)
            {
                _outGoing = value + 8;
            }
            else if (value > 10000 && value < 20000)
            {
                _outGoing = value + 15;
            }
            else if (value > 20000)
            {
                _outGoing = value * 1.08;
            }
        }
    }

    public override string ToString()
    {
        return $"Iban : {Iban}, İsim : {Name}, Gelen Para : {Incoming}, Giden Para : {OutGoing}, Toplam : {Total}";
    }
}