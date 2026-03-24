string[] urunler = {"bilgisayar","telefon","saat","televizyon"};
int[] fiyatlar = {30000,20000,10000,5000};

int toplamSepet = 0;
string devamMi = "E";

while(devamMi == "E" || devamMi == "e")
{
    for(int i = 0; i<urunler.Length; i++)
    {
        Console.WriteLine($"{i+1} - {urunler[i]} : {fiyatlar[i]} tl");
    }

    Console.WriteLine("Lütfen almak istediğiniz ürünün numarasını giriniz: ");
    int secim = Convert.ToInt32(Console.ReadLine());
    toplamSepet = toplamSepet + fiyatlar[secim-1];

    Console.WriteLine($"Ürün sepete eklendi! Mevcut tutar: {toplamSepet} tl ");

    Console.WriteLine("başka bir arzunuz varmı? (e/h)");
    devamMi = Console.ReadLine();
}

Console.WriteLine("Bizi tercih ettiğiniz için teşekkürler.");
Console.WriteLine($"ÖDENECEK TOPLAM TUTAR: {toplamSepet}  TL");