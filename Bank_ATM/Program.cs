int bakiye = 20000;
string sistemSifresi = "1905";

string[] islemler = {"Bakiye Sorgula","Para Çek","Para Yatır","Kredi Başvurusu"};

Console.Write("PIN Kodunuzu Giriniz: ");
var girilenSifre = Console.ReadLine();

if(sistemSifresi == girilenSifre){
    Console.Write("Giriş Başarılı.");
    Console.WriteLine("-------------------");
    
    Console.WriteLine($"1 - {islemler[0]}");
    Console.WriteLine($"2 - {islemler[1]}");
    Console.WriteLine($"3 - {islemler[2]}");
    Console.WriteLine($"4 - {islemler[3]}");

    Console.Write("Lütfen Yapmak İstediğiniz İşlemin Numarasını Giriniz: ");
    var secim = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("-------------------------");
    switch(secim){
        case 1:
            Console.WriteLine($"Mevcut bakiyeniz {bakiye} tl");
            break;
        case 2:
            Console.Write($"Çekmek istediğiniz tutarı girin: ");
            int cekilecekTutar = Convert.ToInt32(Console.ReadLine());

            if(cekilecekTutar>bakiye){
                Console.WriteLine("HATA  Yetersiz bakiye.");
                Console.WriteLine($"çekilebilir tutar {bakiye} tl");
            }
            else{
                bakiye = bakiye - cekilecekTutar;
                Console.WriteLine($"Kalan Bakiye {bakiye} tl");
            }
            break;
        case 3:
            Console.Write("yatırmak istediğiniz tutarı giriniz.");
            int yatirilanTutar = Convert.ToInt32(Console.ReadLine());

            bakiye = bakiye + yatirilanTutar;
            Console.WriteLine("para hesabınıza eklendi ");
            Console.WriteLine($"yeni bakiyeniz {bakiye} tl");
            break;
        case 4:
            Console.WriteLine("Kredi başvuru ekranına hoşgeldiniz.");
            Console.WriteLine("Lütfen aylık gelirinizi giriniz: ");
            int gelir = Convert.ToInt32(Console.ReadLine());

            if(gelir>=10000){
                Console.WriteLine("tebrikler ön onaylı 50.000 tl krediniz hazırlanıyor");
            }
            else{
                Console.WriteLine("üzgünüz şuan için kredi notunuz yetersiz.");
            }
            break;
        default:
            Console.WriteLine("hatalı bir seçim yaptınız kartınız iade ediliyor.");
            break;        
    }   
}
else{
    Console.WriteLine("HATALI ŞİFRE.");
    Console.WriteLine("güvenlik protokolü gereği kartınız bloke edilmiştir");
    Console.WriteLine("lütfen şubenizle iletişime geçiniz.");
}

Console.ReadLine();