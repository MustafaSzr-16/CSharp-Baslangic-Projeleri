

Random rnd = new Random();
int tutulanSayi = rnd.Next(1,101);  // 1 dahil 101 dahil değildir

int tahmin = 0;
int denemeSayisi = 0;

Console.WriteLine("Aklımdan 1 ile 100 arasında bir sayı tuttum. hadi bul.");

while(tahmin != tutulanSayi)
{
    Console.WriteLine("Tahmininiz nedir: ");
    tahmin = Convert.ToInt32(Console.ReadLine());
    denemeSayisi++;

    if (tahmin < tutulanSayi)
    {
        Console.WriteLine("daha büyük bir sayı söyle.");
    }
    else if (tahmin > tutulanSayi)
    {
        Console.WriteLine("daha küçük bir sayı söyle.");
    }
    else
    {
        Console.WriteLine($"Tebrikler! {denemeSayisi}. denemede buldunuz.");
    }
}