using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {

            


            // Class tanımlama 

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Engin Demirig";
            kurs1.IzlenmeOrani = 40;

            Kurs kurs2 = new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.KursunEgitmeni = "Berkay";
            kurs1.IzlenmeOrani = 20;

            Kurs kurs3 = new Kurs();
            kurs1.KursAdi = "C++";
            kurs1.KursunEgitmeni = "Salih ";
            kurs1.IzlenmeOrani = 140;


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.IzlenmeOrani);
            }




            Trendyol Erkek = new Trendyol();
            Erkek.Giyim = "tisort";
            Erkek.Ayakkabi = "Spor";
            Erkek.Esofman = "Alt esofman";


            Trendyol Kadin = new Trendyol();
            Kadin.Giyim = "Elbise";
            Kadin.Ayakkabi = "Topuklu";
            Kadin.Esofman = "Tayt";

            Trendyol Bebek = new Trendyol();
            Bebek.Giyim = "Askili gomlek";
            Bebek.Ayakkabi = "Uzay temali";
            Bebek.Esofman = "Barbie esofman takimi";

            Trendyol[] kategoriler = new Trendyol[] { Erkek, Kadin, Bebek };

            foreach (var x in kategoriler)
            {
                
                Console.WriteLine(x.Giyim);
            }

            Console.WriteLine();

            for(int i=0; i < kategoriler.Length; i++)
            {
                Console.WriteLine(kategoriler[i].Esofman);
            }

            Console.WriteLine();

            int b = 0;
            while (b < kategoriler.Length){
                
                Console.WriteLine(kategoriler[b].Ayakkabi);
                b++;
            }


        }
    }

    class Kurs
    {

        public string KursAdi { get; set; }

        public string KursunEgitmeni { get; set; }

        public int IzlenmeOrani { get; set; }

    }


    class Trendyol
    {
        public string Giyim { get; set; }
        public string Ayakkabi { get; set; }
        public string Esofman { get; set; }

    }











}
