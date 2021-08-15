using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayi1: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sayi2: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());


            DortIslem dortIslem = new DortIslem();

            dortIslem.Topla(sayi1, sayi2);
            dortIslem.Cıkar(sayi1, sayi2);
            dortIslem.Carp(sayi1, sayi2);
            dortIslem.Bol(sayi1, sayi2);
            

        }
    }
}
