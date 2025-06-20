using System;

namespace ForDongusuAlistirmalari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 -> Motivasyon mesajını 10 kez yazdırma");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}) Kendime inanıyorum, ben bu yazılım işini hallederim!");
            }

            Console.WriteLine("\n2 -> 1 ile 20 arasındaki sayılar");
            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n\n3 -> 1 ile 20 arasındaki çift sayılar");
            for (int i = 2; i <= 20; i += 2)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n\n4 -> 50 ile 150 arasındaki sayıların toplamı");
            int toplam = 0;
            for (int i = 50; i <= 150; i++)
            {
                toplam += i;
            }
            Console.WriteLine($"Toplam: {toplam}");

            Console.WriteLine("\n5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamları");
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 120; i++)
            {
                if (i % 2 == 0)
                    ciftToplam += i;
                else
                    tekToplam += i;
            }
            Console.WriteLine($"Tek sayıların toplamı: {tekToplam}");
            Console.WriteLine($"Çift sayıların toplamı: {ciftToplam}");

            Console.ReadKey();
        }
    }
}
