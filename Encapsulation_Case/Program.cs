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
using Encapsulation_Case;

Account account = new Account("TR330006100519786457841326", "Berkay", 100000, 20001);

Console.WriteLine(account);