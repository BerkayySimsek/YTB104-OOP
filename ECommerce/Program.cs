
using ECommerce;

//BasePayment payment = new CreditCardPayment()
//{
//    Amount = 12500,
//    CardNumber = "7854 6478 1254 6875",
//    CVV = "005",
//    Expiration = "08/29",
//    FullName = "Berkay Şimşek"
//};

//BasePayment payment1 = new IbanPayment()
//{
//    AccountNo = "TR330006100519786457841326",
//    Amount = 12500
//};

//payment.Pay();

BasePayment payment = null;

Console.WriteLine("Ödeme Yöntemi Seçiniz : ");
Console.WriteLine("1-> Kredi Kartı ile öde");
Console.WriteLine("2-> Iban ile öde");

int operation = Convert.ToInt32(Console.ReadLine());

if (operation == 1)
{
    Console.WriteLine("Kart üzerinde yazan tüm isim :");
    string fullName = Console.ReadLine();

    Console.WriteLine("Kart No :");
    string cardNumber = Console.ReadLine();

    Console.WriteLine("CVV :");
    string cvv = Console.ReadLine();

    Console.WriteLine("Geçerlilik Tarihi :");
    string expiration = Console.ReadLine();

    payment = new CreditCardPayment()
    {
        Amount = 12500,
        CardNumber = cardNumber,
        CVV = cvv,
        Expiration = expiration,
        FullName = fullName
    };
    payment.Pay();
}
else if (operation == 2)
{
    Console.WriteLine("Hesap No :");
    string accountNo = Console.ReadLine();

    payment = new IbanPayment()
    {
        Amount = 1200,
        AccountNo = accountNo
    };
    payment.Pay();
}

// 1.Yöntem
if (payment.GetType() == typeof(CreditCardPayment))
{
    // explicit conversion
    CreditCardPayment creditCard = (CreditCardPayment)payment;
    Console.WriteLine($"Kredi Kartı No : {creditCard.CardNumber}");
    Console.WriteLine("Kredi Kartı ile ödendi.");
}
else if (payment.GetType() == typeof(IbanPayment))
{
    IbanPayment iban = (IbanPayment)payment;
    Console.WriteLine($"Iban no : {iban.AccountNo}");
    Console.WriteLine("Iban ile ödendi.");
}

// 2. Yöntem
if (payment is IbanPayment)
{
    IbanPayment iban = (IbanPayment)payment;
    Console.WriteLine($"Iban no : {iban.AccountNo}");
    Console.WriteLine("Iban ile ödendi.");
}
else if (payment is CreditCardPayment)
{
    CreditCardPayment creditCard = (CreditCardPayment)payment;
    Console.WriteLine($"Kredi Kartı No : {creditCard.CardNumber}");
    Console.WriteLine("Kredi Kartı ile ödendi.");
}

// 3. Yöntem
if (payment is IbanPayment ibanNo)
{
    Console.WriteLine($"Iban no : {ibanNo.AccountNo}");
    Console.WriteLine("Iban ile ödendi.");
}
else if (payment is CreditCardPayment creditCard)
{
    Console.WriteLine($"Kredi Kartı No : {creditCard.CardNumber}");
    Console.WriteLine("Kredi Kartı ile ödendi.");
}