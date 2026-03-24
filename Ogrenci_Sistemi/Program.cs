string[] ogrenciler = {"ali","ayşe","mehmet","fatma"};
int[] notlar = {0,0,0,0};

string sistemAcik = "E";

while(sistemAcik == "E" || sistemAcik == "e")
{
    Console.WriteLine("1- not girişi yap");
    Console.WriteLine("2- sınıf durumunu gör");
    Console.WriteLine("3- çıkış yap");

    int secim = Convert.ToInt32(Console.ReadLine());

    switch (secim)
    {
        case 1:
            for(int i = 0; i<ogrenciler.Length; i++)
            {
                Console.WriteLine($"{ogrenciler[i]} isimli öğrencinin notunu giriniz");
                notlar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("notlar sisteme başarıyla kaydedilmiştir.");
            break;
        case 2:
            for(int i = 0; i<ogrenciler.Length; i++)
            {
                if(notlar[i] >= 85)
                {
                    Console.WriteLine($"{ogrenciler[i]} - notu: {notlar[i]} - durum: AA (Geçti)");
                }
                else if(notlar[i] >= 70)
                {
                    Console.WriteLine($"{ogrenciler[i]} - notu: {notlar[i]} - durum: BB (Geçti)");
                }
                else if(notlar[i] >= 50)
                {
                    Console.WriteLine($"{ogrenciler[i]} - notu: {notlar[i]} - durum: CC (Geçti)");
                }
                else
                {
                    Console.WriteLine($"{ogrenciler[i]} - notu: {notlar[i]} - durum: FF (Kaldı)");
                }
            }
            break;
        case 3:
            Console.WriteLine("sistemden çıkılıyor. İyi günler hocam");
            sistemAcik = "H";
            break;
        default:
            Console.WriteLine("hatalı bir seçim yaptınız. lütfen 1,2 veya 3 tuşlayın.");
            break;    
    }
}