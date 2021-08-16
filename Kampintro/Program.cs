using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {

            // type safety = tip güvenliği
            // do not repeat yourself  = kendini tekrar etme 

            //Variables -değişkenler

            string isim = "Sefa";
            int TamSayi = 12;
            double OndalikliSayi = 3.4;
            bool trueOrFalse = true;

            double dolarBugun = 7.45;
            double dolarDun = 7.35;

            //Sart blokları

            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Yukseldi butuno");
            }
            else if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Dustu butonu");
            }
            else
            {
                Console.WriteLine("Degişmedi");
            }

            /*
            Console.Write("Isminizi giriniz: ");
            string isim = Console.ReadLine();
            Console.WriteLine("Ad: " + isim);

            Console.Write("Yas: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yası: "+ yas);
            */

            /*
            string text = "ABcdEfG";
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());


            string FirstName = "Sefa";
            string LastName = "Ciftci";

            string name = $"Full Name: {FirstName} {LastName}";
            Console.WriteLine(name);

            string test = "Deneme";
            Console.WriteLine(test.IndexOf("e"));
            Console.WriteLine(test[2]);
            */




            /*
            Console.Write("What day is today?  ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday ");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Error There are only 7 day :)");
                    break;
            }

            */


            /*While loop / 

            int x = 0;
            while (x < 10)
            {
                Console.WriteLine(x);
                x++;
            }


            Do-While
            
             

            int y = 5;
            do
            {
                Console.WriteLine(y);
                y++;
            } while (y>10);




            For loops


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }



            Foreach

            string[] markalar = new string[] { "Facebook", "Google", "Apple" };

            foreach (var Marka in markalar)
            {
                Console.WriteLine(Marka);
            }


            

            int a = 0;

            while (a<10)
            {

                Console.WriteLine(a);
                a++;

                if (a == 4)
                {
                    a++;
                    continue;
                }
                else if (a == 7)
                {
                    break;
                }

            }


            string[] names = { "Sefa", "Ahmet", "Fatma" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }


            Console.WriteLine();


            foreach (var x in names)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();

            Array.Sort(names);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            */


            Console.WriteLine("--------------------------------------");

            sayi(2,4);
            sayi();



        }

        static int sayi(int sayi1= 0, int sayi2=3 )
        {
            
            
        }

    }
}
