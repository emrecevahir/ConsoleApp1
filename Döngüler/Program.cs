using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            //string kurs2 = "Programlamaya başlangıç için temel kurs";
            //string kurs3 = "Java Kursu";

            //Console.WriteLine(kurs1);
            //Console.WriteLine(kurs2);
            //Console.WriteLine(kurs3);
          
            //böyle teker teker yazmak yerine bir kere kurslar içinde tanımlayıp for döngüsüyle tekte yazdırabiliriz
            //array - dizi tanımlama

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java Kursu","c#", "python" };
             


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            
            Console.WriteLine("for bitti");
            
            // farklı bir döngü şekli for yazıp aşağı tuşa basıp foreach girip 2 tab bas
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
