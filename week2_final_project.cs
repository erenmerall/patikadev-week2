using System;

namespace Week2FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Merhaba\nNasılsın?");
            Console.WriteLine("İyiyim\nSen nasılsın?\n\n");

            // 2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
            string text = "Metinsel Veri";
            int number = 123;
            Console.WriteLine($"2- Metinsel Veri: {text} -  Sayısal Veri: {number}\n\n");

            // 3 - Rastgele bir sayı üretip , ekrana yazdırınız.
            Random random = new Random();
            int randomNumber = random.Next(1, 101); // 1 ile 100
            Console.WriteLine($"3- Rastgele Üretilen Sayı: {randomNumber}\n\n");

            // 4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
            int remainder = randomNumber % 3;
            Console.WriteLine($"4- Rastgele Üretilen Sayının 3'e Bölümünden Kalan: {remainder}\n\n");

            // 5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
            Console.WriteLine("5- Lütfen yaşınızı giriniz:");
            int age;
            age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("+\n\n");
            }
            else
            {
                Console.WriteLine("-\n\n");
            }

            // 6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");
            }

            // 7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
            Console.WriteLine("\n\n7- Lütfen ilk metni giriniz:");
            string firstText = Console.ReadLine();
            Console.WriteLine("\n\nLütfen ikinci metni giriniz:");
            string secondText = Console.ReadLine();
            string temp = firstText;
            firstText = secondText;
            secondText = temp;
            Console.WriteLine($"Gülse Birsel: {firstText} - Demet Evgar: {secondText}\n\n");
            // burada ne istendiğini tam olarak anlayamadım ve böyle bir şey yaptım.

            // 8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
            BenDegerDondurmem();

            // 9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
            Console.WriteLine("9- Lütfen ilk sayıyı giriniz:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int sum = AddTwoNumbers(firstNumber, secondNumber);
            Console.WriteLine($"Toplam: {sum}\n\n");

            // 10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
            Console.Write("10 - Lütfen true ya da false yazınız: ");
            bool userInput;
            try
            {
                userInput = Convert.ToBoolean(Console.ReadLine());
            }
            catch
            {
                Console.Write("Geçersiz giriş! Lütfen sadece 'true' ya da 'false' yazınız: ");
                userInput = Convert.ToBoolean(Console.ReadLine());
            }
            string result = EvaluateBoolean(userInput);
            Console.WriteLine($"Sonuç: {result}\n\n");

            //  11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
            Console.WriteLine("11- Lütfen 1. kişinin yaşını giriniz:");
            int age1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2. kişinin yapşını giriniz:");
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 3. kişinin yapşını giriniz:");
            int age3 = Convert.ToInt32(Console.ReadLine());
            int maxAge = Math.Max(age1, Math.Max(age2, age3));
            Console.WriteLine($"En yaslı kişinin yası: {maxAge}\n\n");

            // 12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
            int max = FindMaxNumber();
            Console.WriteLine($"\nGirdiğiniz sayıların en büyüğü: {max}");

            // 13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
            Console.WriteLine("\n\n13- Lütfen ilk ismi giriniz:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Lütfen ikinci ismi giriniz:");
            string lastName = Console.ReadLine();
            ChangeNames(firstName, lastName);

            // 14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
            Console.WriteLine("\n\n14- Lütfen bir sayı giriniz:");
            int userNumber;
            try
            {
                userNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Geçersiz giriş! Lütfen sadece sayı giriniz.");
                return;
            }
            bool isEven = IsEven(userNumber);
            Console.WriteLine($"Girdiğiniz sayının tek mi çift mi: {isEven}");


            // 15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
            Console.WriteLine("\n\n15- Lütfen hızı (km/s) giriniz:");
            double speed;
            try
            {
                speed = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Geçersiz giriş! Lütfen sadece sayı giriniz.");
                return;
            }
            Console.WriteLine("Lütfen zamanı (s) giriniz:");
            double time;
            try
            {
                time = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Geçersiz giriş! Lütfen sadece sayı giriniz.");
                return;
            }
            double distance = CalculateDistance(speed, time);
            Console.WriteLine($"Gidilen yol: {distance} km");

            // 16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
            Console.WriteLine("\n\n16- Lütfen dairenin yarıçapını giriniz:");
            double radius;
            try
            {
                radius = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Geçersiz giriş! Lütfen sadece sayı giriniz.");
                return;
            }
            double area = CalculateArea(radius);
            Console.WriteLine($"Dairenin alani: {area} m^2");

            // 17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
            string sentence = "Zaman bir GeRi SayIm";
            Console.WriteLine($"\n\n17- Büyük harfle: {sentence.ToUpper()}");
            Console.WriteLine($"Küçük harfle: {sentence.ToLower()}\n\n");

            // 18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
            string greeting = "    Selamlar   ";
            Console.WriteLine($"18- metnin ilk hali: {greeting}");
            greeting = greeting.Trim();
            Console.WriteLine($"Kalıcı olarak silindi: {greeting}\n\n");

        }
        public static void BenDegerDondurmem()
        {
            Console.WriteLine("8- Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma.\n\n");
        }

        public static int AddTwoNumbers(int number1, int number2)
        {
            return number1 + number2;
        }

        static string EvaluateBoolean(bool value)
        {
            if (value)
                return "Giriş başarılı!";
            else
                return "Giriş reddedildi!";
        }

        static int FindMaxNumber()
        {
            List<int> numbers = new List<int>();
            string input;

            Console.WriteLine("Sayı girişi başlatıldı. Bitirmek için 'q' yazınız.");

            while (true)
            {
                Console.Write("Bir sayı girin: ");
                input = Console.ReadLine();

                if (input.ToLower() == "q")
                    break;

                try
                {
                    int number = Convert.ToInt32(input);
                    numbers.Add(number);
                }
                catch
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen sadece sayı girin veya çıkmak için 'q' yazın.");
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("Hiç sayı girilmedi.");
                return 0;
            }

            int max = numbers[0];
            foreach (int n in numbers)
            {
                if (n > max)
                    max = n;
            }

            return max;
        }

        static void ChangeNames(string firstName, string lastName)
        {
            string temp = firstName;
            firstName = lastName;
            lastName = temp;
            Console.WriteLine($"Değiştirilen İsimler: {firstName} - {lastName}\n\n");
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static double CalculateDistance(double speed, double time)
        {
            return speed * time; // Yol = Hız x Zaman
        }

        static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius; // Alan = π x r^2
        }
    }
}
