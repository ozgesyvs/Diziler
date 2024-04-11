using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace diziler{


    class Diziler{

        static void Main(string[] args){



            /*

            Aynı tipteki değişkenleri bellekte arka arkaya
            saklamak istediğimizde dizileri kullanırız

            Diziler 0.indexten başlar

            */

            //Dizi Tanımlama

            string[] renkler = new string[5];

            string[] hayvanlar = {"kedi","köpek","kuş","maymun"};

            int[] dizi;

            dizi = new int[5];



            //Dizilere Değer Atama ve Erişim

            renkler[0] = "Mavi";

            Console.WriteLine(renkler[0]);

            Console.WriteLine(hayvanlar[2]);

            dizi[0] = 5;

            Console.WriteLine(dizi[0]);



            //Döngülerle Dizi Kullanımı

            //Klavyeden girilen n tane sayının ortalamasını alan program

            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz:");

            int diziUzunlugu = Int32.Parse(Console.ReadLine());

            int[] yeniDizi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}.elemanı girin:",i+1);
                yeniDizi[i] = Int32.Parse(Console.ReadLine());
    
            }



            int toplam = 0; 

            foreach (var item in yeniDizi)
            {
                toplam = item + toplam;
            }

            Console.WriteLine("Ortalama:" + toplam/diziUzunlugu);


























        }
    }
}