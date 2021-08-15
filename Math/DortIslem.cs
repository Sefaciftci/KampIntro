using System;
using System.Collections.Generic;
using System.Text;

namespace Math
{
    class DortIslem
    {

        public void Topla(int sayi1 ,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sayi1 +  " + " + sayi2 +" = " + sonuc );

        }

        public void Cıkar(int sayi1 ,int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine(sayi1 + " - " + sayi2 + " = " + sonuc);
        }

        public void Carp(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine(sayi1 + " x " + sayi2 + " = " + sonuc);
        }

        public void Bol(int sayi1, int sayi2)
        {
            int sonuc = sayi1 / sayi2;
            Console.WriteLine(sayi1 + " / " + sayi2 + " = " + sonuc);
        }


    }
}
