Console.Write("Sinema Bilet Sistemine Hoş Geldiniz.");

Console.WriteLine("Lütfen ad ve soyad giriniz.");
string adSoyad = Console.ReadLine();

Console.Write($"Merhaba {adSoyad}.");

Console.WriteLine("Lütfen yaşınızı giriniz.");
int yas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("öğrenci misiniz?(e/h)");
string ogrenciCevap = Console.ReadLine().ToLower();

bool ogrenciMi = false;

if(ogrenciCevap == "e")
{
    ogrenciMi = true;
}
else if(ogrenciCevap == "h")
{
    ogrenciMi = false;
}
else
{
    Console.WriteLine("hatalı bir giriş yaptınız.Öğrenci bilgisi için sadece e veya h giriniz.");
}

Console.WriteLine();
Console.WriteLine("Film türü seçiniz: ");
Console.WriteLine("1 - Aksiyon");
Console.WriteLine("2 - Komedi");
Console.WriteLine("3 - Korku");
Console.WriteLine("4 - Animasyon");
Console.Write("Seçiminiz: ");
int filmSecimi = Convert.ToInt32(Console.ReadLine());

string filmTuru = "";
double tabanFiyat = 0;
bool filmGeçerliMi = true;

switch (filmSecimi)
{
    case 1:
        filmTuru = "Aksiyon";
        tabanFiyat = 180;
        break;

    case 2: 
        filmTuru = "Komedi";
        tabanFiyat = 150;
        break;

    case 3:
        filmTuru = "Korku";
        tabanFiyat = 160;
        break;

    case 4:
        filmTuru = "Animasyon";
        tabanFiyat = 140;
        break;

    default:
        Console.WriteLine("geçersiz film seçimi yaptınız.");
        filmGeçerliMi = false;
        break;
}

Console.WriteLine("----------------------------");
Console.WriteLine("seans seçiniz:");
Console.WriteLine("1 - 13:00");
Console.WriteLine("2 - 16:00");
Console.WriteLine("3 - 20:00");
Console.Write("seçiminiz: ");
int seansSecimi = Convert.ToInt32(Console.ReadLine());

string seans = "";
double seansEkUcreti = 0;
bool seansGecerliMi = true;

switch (seansSecimi)
{
    case 1:
        seans = "13:00";
        seansEkUcreti = 0;
        break;
    
    case 2:
        seans = "16:00";
        seansEkUcreti = 0;
        break;

    case 3:
        seans = "20:00";
        seansEkUcreti = 20;
        break;
    
    default:
        Console.WriteLine("Geçersiz seans seçimi yaptınız.");
        seansGecerliMi = false;
        break;
}

Console.WriteLine("-------------------------------------");
Console.Write("Kaç adet bilet istiyorsunuz?");
int biletAdedi = Convert.ToInt32(Console.ReadLine());

bool biletGecerliMi = false;

if(biletAdedi <= 0)
{
    Console.WriteLine("bilet adedi 1 veya daha büyük olmalı.");
    biletGecerliMi = false;
}

bool yasUygunMu = true;

if(filmTuru == "Korku" && yas < 18)
{
    Console.WriteLine("bu filme giriş için yaşınız uygun değil.");
    yasUygunMu = false;
}

double normalBirimFiyat = tabanFiyat + seansEkUcreti;
double indirimliBirimFiyat = normalBirimFiyat;
double indirimTutari = 0;

if(ogrenciMi == true)
{
    indirimTutari = normalBirimFiyat * 0.20;
    indirimliBirimFiyat = normalBirimFiyat -indirimTutari;
}

double toplamTutar = indirimliBirimFiyat * biletAdedi;

DateTime simdi = DateTime.Now;

if(filmGeçerliMi == true && seansGecerliMi == true && biletGecerliMi && yasUygunMu == true && (ogrenciCevap == "e" || ogrenciCevap == "h"))
{
    Console.WriteLine();
    Console.WriteLine("-------Bilet Özeti----------");
    Console.WriteLine($"Ad soyad: {adSoyad}");
    Console.WriteLine($"yaş: {yas}");
    Console.WriteLine("Öğrenci mi: " + (ogrenciMi ? "Evet": "Hayır"));
    Console.WriteLine($"film türü: {filmTuru}");
    Console.WriteLine($"seans: {seans}");
    Console.WriteLine($"Bilet adedi: {biletAdedi}");
    Console.WriteLine($"Normal birim fiyat: {normalBirimFiyat} tl");
    Console.WriteLine($"indirim tutarı: {indirimTutari} tl");
    Console.WriteLine($"İndirimli birim fiyatı: {indirimliBirimFiyat} tl");
    Console.WriteLine($"toplam tutarı: {toplamTutar} tl ");
    Console.WriteLine($"tarih: {simdi}");
    Console.WriteLine("İYİ SEYİRLER.");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Bilet oluşturulamadı.Lütfen bilgilerinizi kontrol edin.");
}

