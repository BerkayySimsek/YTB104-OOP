namespace Encapsulation_Case;

//Account adında class oluşturunuz
//account sınıfının propertyleri 
//●	Iban numarası (string)
//●	Kişi adı
//●	Gelen para
//●	Giden para
//●	Toplam para

//eğer giden para değeri 1000 tl üzerinde ise ekstradan 4 tl
//2000 tl üzerindeyse 8 tl 
//10000 tl üzerindeyse 15 tl 
//20000 tl nin üzerinde ise %8 ekstra dan eklensin

//●	Toplam para değeri gelen para - giden para şeklinde hesaplanmalıdır
//Konu : Encapsulation
public class Account
{
    private double _withdrawal;
    public string? IbanNo { get; set; }
    public string? Name { get; set; }
    public double Deposit { get; set; }
    public double Withdrawal
    {
        get => _withdrawal;

        set
        {
            double fee = 0;
            if (value > 20000)
            {
                fee = value * 0.08;
            }
            else if (value > 10000)
            {
                fee = 15;
            }
            else if (value > 2000)
            {
                fee = 8;
            }
            else if (value > 1000)
            {
                fee = 4;
            }
            _withdrawal = value + fee;
        }
    }
    public double TotalAmount
    {
        get => Deposit - Withdrawal;
    }
    public Account(string ibanNumber, string personName, double paraYatir, double paraCek)
    {
        IbanNo = ibanNumber;
        Name = personName;
        Deposit = paraYatir;
        Withdrawal = paraCek;
    }
    public override string ToString()
    {
        return $"IBAN : {IbanNo}\nKişi Adı : {Name}\nYatırılan Tutar : {Deposit}\nÇekilen Tutar (Komisyon Dahil) : {Withdrawal}\nBakiye : {TotalAmount}";
    }
}
