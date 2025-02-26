namespace ECommerce;

public class CreditCardPayment : BasePayment
{

    public string? CardNumber { get; set; }
    public string? CVV { get; set; }
    public string? Expiration { get; set; }
    public string? FullName { get; set; }

    public override void Pay()
    {
        Console.WriteLine($"Number : {CardNumber}");
        Console.WriteLine($"CVV : {CVV}, Son Kullanım Tarihi : {Expiration}");
        Console.WriteLine($"Tüm ad : {FullName}");
        Console.WriteLine($"Tutar : {Amount}");
    }
}
