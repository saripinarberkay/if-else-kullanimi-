// See https://aka.ms/new-console-template for more information

Console.WriteLine("ORTALAMALARINI HESAPLAMAK İÇİN 3 SAYI GİR ");
Console.WriteLine("1. SAYI : ");
double sayi1 = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("2. Sayı");
double sayi2 = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("3. SAYI: ");
double sayi3 = Convert.ToInt32( Console.ReadLine());
double sonuc = (sayi1 + sayi2 + sayi3) / 3;
Console.WriteLine("SONUÇ: " + sonuc);

if (sonuc > 10)
{
    Console.WriteLine("Sonuc 10'Dan büyük");
}
else if  (sonuc == 10) {
    Console.WriteLine("Sonucunuz 10'la eşit");
}
else
{
    Console.WriteLine("Sonuc 10'dan küçük");
}
Console.ReadKey();
