using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 8;
            product1.Aciklama = "Amasya Elmasi";


            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 2;
            product2.Aciklama = "Diyarbakir Karpuzu";


            Product[] products = new Product[] { product1, product2 };

            foreach (Product prdct in products)
            {
                Console.WriteLine(prdct.Adi);
                Console.WriteLine(prdct.Fiyati);
                Console.WriteLine(prdct.Aciklama);
                Console.WriteLine("------------------------");

            }

            //instance => Örnek
            //Encapsulation => Düzene sokmak 'kapsülleme'


            Console.WriteLine("-------------Metotlar-----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);





        }
    }
}
