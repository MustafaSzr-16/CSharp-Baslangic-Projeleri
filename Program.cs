

string[] urunler = {"telefon","bilgisayar","televizyon"};
int[] fiyatlar = {10000,20000,30000};

Console.WriteLine($"1. ürün: {urunler[0]} - {fiyatlar[0]} tl");
Console.WriteLine($"2.ürün: {urunler[1]} - {fiyatlar[1]} tl");
Console.WriteLine($"3. ürün: {urunler[2]} - {fiyatlar[2]} tl");


Console.Write("sepete eklemek istediğiniz 1.ürünün numarasını (0,1 veya 2 olarak girin): ");
var sepet1 = Convert.ToInt32(Console.ReadLine());

Console.Write("sepete eklemek istediğiniz 2.ürünün numarasını (0,1 veya 2 olarak girin): ");
var sepet2 = Convert.ToInt32(Console.ReadLine());

Console.Write("sepete eklemek istediğiniz 3.ürünün numarasını (0,1 veya 2 olarak girin): ");
var sepet3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(sepet1);
Console.WriteLine(sepet2);
Console.WriteLine(sepet3);

int toplamTutar = fiyatlar[sepet1] + fiyatlar[sepet2] + fiyatlar[sepet3];
Console.WriteLine($"seçilen ürünler {urunler[sepet1]}, {urunler[sepet2]}, {urunler[sepet3]}");
Console.WriteLine($"ödemeniz gereken toplam tutar: {toplamTutar} tl");
