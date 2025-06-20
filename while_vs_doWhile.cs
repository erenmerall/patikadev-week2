using System;

namespace WhileVsDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bir sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int counter1 = 0;
            Console.WriteLine("\nWhile döngüsü ile yazdırma");
            while (counter1 < number)
            {
                Console.WriteLine($"{counter1 + 1}) - Ben bir Patika'lıyım");
                counter1++;
            }
            Console.WriteLine("\n----------------------------------------------------------------------------\n");

            Console.WriteLine("do-while döngüsü ile yazdırma");
            int counter2 = 0;
            do
            {
                Console.WriteLine($"{counter2 + 1}) - Ben bir Patika'lıyım");
                counter2++;
            } while (counter2 < number);

            Console.ReadKey();

            /*
                while döngüsü önce koşulu kontrol eder, eğer koşul sağlanıyorsa döngüye girer.
                do-while döngüsü ise önce döngü içindeki kodu çalıştırır, ardından koşulu kontrol eder.
                ikisi de çok benzer şekilde çalışır. temel bir farklılık mevcuttur.
                do-while döngüsü en az bir kez çalışır, çünkü koşul kontrolü döngü sonunda yapılır.
                bu nedenle, eğer kullanıcı 0 veya negatif bir sayı girerse, while döngüsü hiç çalışmayabilir, ancak do-while döngüsü en az bir kez çalışacaktır.
            */
        }
    }
}
