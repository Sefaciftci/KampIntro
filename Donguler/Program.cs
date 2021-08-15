using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            // Arrays -Diziler-

            string[] kurslar = new string[]
            {
                "Programlamaya Giris Kursu",
                "C# Kursu",
                "Java Kursu"
            };


            for(int i=0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



            // Loobs -Döngüler-

            for (int i = 0; i < 10; i+=2)
            {
                Console.WriteLine(i);
            }


            

            


        }
    }
}
