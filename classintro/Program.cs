using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            String adi = "emre";
            int yas = 24;
            
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Emre Cevahir";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Umut";
            kurs2.İzlenmeOrani = 69;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Ciko";
            kurs3.İzlenmeOrani = 23;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
            }
            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);
        }
    }

    class Kurs
    {
        //prop yazıp 2 tab
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }

    }
}
