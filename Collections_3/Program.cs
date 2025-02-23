// HashSet bir listede tekrarlayan eleman varsa o tekrarlayan elemanı tekrar edilmemiş haliyle ekler.
HashSet<int> sayilar = new HashSet<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 7, 8, 9878 };
//foreach (int sayi in sayilar)
//{
//    Console.WriteLine(sayi);
//}

// anahtar değer şeklinde tutulan çoklu veri örneklerine Dictionary denilebilir.

// Karga - Crow
// Türkçe - İngilizce sözlüğü oluşturunuz.

Dictionary<string, string> myDictionary = new Dictionary<string, string>();

myDictionary.Add("Crow", "Karga");
myDictionary.Add("Lion", "Aslan");
myDictionary.Add("Dog", "Köpek");
myDictionary.Add("Tiger", "Kaplan");

Console.WriteLine(myDictionary["Crow"]);

foreach (KeyValuePair<string, string> sozluk in myDictionary)
{
    Console.WriteLine($"İngilizce : {sozluk.Key} -> Türkçe : {sozluk.Value}");
}

Dictionary<string, double> manav = new Dictionary<string, double>();

manav.Add("Elma", 25.5);
manav.Add("Armut", 35);
manav.Add("Karpuz", 20);
manav.Add("Kiraz", 32);
manav.Add("Kayısı", 29.5);
manav.Add("Muz", 45);

foreach (KeyValuePair<string, double> sozluk in manav)
{
    Console.WriteLine($"Meyve Adı : {sozluk.Key} -> Değeri : {sozluk.Value}");
}