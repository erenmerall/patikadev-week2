using System;

namespace MethodExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Geriye değer döndürmeyen ve parametre almayan void metot
            SongLyrics();

            // 2) Geriye tamsayı döndüren, parametre almayan metot
            int remainder = GetRandomRemainder();
            Console.WriteLine($"Rastgele sayının 2'ye bölümünden kalan: {remainder}");

            // 3) Parametre alan ve geriye değer döndüren metot
            int productResult = MultiplyNumbers(6, 7);
            Console.WriteLine($"\n6 ile 7'nin çarpımı: {productResult}");

            // 4) Parametre alan ve geriye değer döndürmeyen metot
            ShowWelcomeMessage("Eren", "Meral");
        }

        // 1) Void, parametresiz metot – Şarkı sözü yazdıran
        static void SongLyrics()
        {
            Console.WriteLine("Düşlerle gerçekler ayrı ayrı yaşar. - Sezen Aksu");
        }

        // 2) Geriye int döndüren, parametresiz metot – Rastgele sayıdan kalan
        static int GetRandomRemainder()
        {
            Random random = new Random();
            int number = random.Next(1, 101); // 1 ile 100 arasında
            Console.WriteLine($"\nRastgele seçilen sayı: {number}");
            return number % 2;
        }

        // 3) Geriye int döndüren, parametre alan metot – İki sayının çarpımı
        static int MultiplyNumbers(int number1, int number2)
        {
            return number1 * number2;
        }

        // 4) Void, parametre alan metot – Hoş geldiniz mesajı
        static void ShowWelcomeMessage(string firstName, string lastName)
        {
            Console.WriteLine($"\nHoş Geldiniz {firstName} {lastName}!");
        }
    }
}
