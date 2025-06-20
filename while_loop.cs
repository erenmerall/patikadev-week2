using System;

namespace WhileDongusuAlistirmalari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 -> Motivasyon mesajını 10 kez yazdırma");
            int sayac1 = 1;
            while (sayac1 <= 10)
            {
                Console.WriteLine($"{sayac1}) Kendime inanıyorum, ben bu yazılım işini hallederim!");
                sayac1++;
            }

            Console.WriteLine("\n2 -> 1 ile 20 arasındaki sayılar");
            int sayac2 = 1;
            while (sayac2 <= 20)
            {
                Console.Write($"{sayac2} ");
                sayac2++;
            }

            Console.WriteLine("\n\n3 -> 1 ile 20 arasındaki çift sayılar");
            int sayac3 = 2;
            while (sayac3 <= 20)
            {
                Console.Write($"{sayac3} ");
                sayac3 += 2;
            }

            Console.WriteLine("\n\n4 -> 50 ile 150 arasındaki sayıların toplamı");
            int sayac4 = 50;
            int toplam = 0;
            while (sayac4 <= 150)
            {
                toplam += sayac4;
                sayac4++;
            }
            Console.WriteLine($"Toplam: {toplam}");

            Console.WriteLine("\n5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamları");
            int sayac5 = 1;
            int tekToplam = 0;
            int ciftToplam = 0;
            while (sayac5 <= 120)
            {
                if (sayac5 % 2 == 0)
                    ciftToplam += sayac5;
                else
                    tekToplam += sayac5;

                sayac5++;
            }
            Console.WriteLine($"Tek sayıların toplamı: {tekToplam}");
            Console.WriteLine($"Çift sayıların toplamı: {ciftToplam}");

            Console.ReadKey();
        }
    }
}
