using System;

namespace YolArkadasi
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                //lokasyonlar
                int bodrumStarterPack = 4000;
                int marmarisStarterPack = 3000;
                int cesmeStarterPack = 5000;

                Console.WriteLine("Yol Arkadaşım Uygulamasına Hoş Geldiniz!");
                Console.WriteLine("Lütfen bir lokasyon seçiniz: (bodrum, marmaris, cesme)");
                string location = Console.ReadLine().ToLower();

                int starterPack = 0;
                if (location == "bodrum")
                {
                    starterPack = bodrumStarterPack;
                }
                else if (location == "marmaris")
                {
                    starterPack = marmarisStarterPack;
                }
                else if (location == "cesme")
                {
                    starterPack = cesmeStarterPack;
                }

                Console.WriteLine("kaç kişilik bir yolculuk planlıyorsunuz? ");
                int numberOfPeople = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"\n{numberOfPeople} kisilik {location} tatilinizde yaz günlerinin vazgeçilmezi olan denizin tadını çıkarabiilir ve akşamları çeşitli eğlencelerle tatilinize renk katabilirsiniz.\n");

                Console.WriteLine("\n1-Kara yolu (Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL)\n2-Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL) \nUlaşım için hangi yolu tercih edersiniz? ");
                int transportRoad;
                while (true)
                {
                    transportRoad = Convert.ToInt32(Console.ReadLine());
                    if (transportRoad == 1 || transportRoad == 2)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz bir ulaşım yolu seçtiniz. Lütfen 1 veya 2 giriniz.");
                    }
                }

                int transportCost = 0;
                if (transportRoad == 1)
                {
                    transportCost = 1500;
                }
                else if (transportRoad == 2)
                {
                    transportCost = 4000;
                }

                int totalCost = (starterPack + transportCost) * numberOfPeople;
                Console.WriteLine($"\nBu tatil için harcayacağınız toplam tutar: {totalCost} TL\nİyi tatiller dileriz!");

                // Yeni tatil isteği
                Console.WriteLine("\nBaşka bir tatil planlamak ister misiniz? (evet / hayır)");
                string? again = Console.ReadLine()?.ToLower();

                if (again != "evet")
                {
                    Console.WriteLine("\nBizi tercih ettiğiniz için teşekkür ederiz. İyi günler!");
                    break;
                }
            }
        }
    }
}
