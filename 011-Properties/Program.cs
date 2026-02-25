using System;

namespace _011_Properties
{
    class Skorlar
    {
        private int skor;
        public int Skor
        {
            get { return skor; } // deyimi ile private skor değişkenini okuyor ve çağırıldığı yere bu değeri döndürüyor.
            set { skor = value; } // deyimi ile sınıfın private değişkenine value değerini atıyor.
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Hem değişken hem metod özelliği taşır.
            Skorlar skorlar = new Skorlar();
            skorlar.Skor = 5;
            Console.WriteLine(skorlar.Skor);

            Kisi kisi = new Kisi();
            kisi.Ad = "Ali";
            kisi.Aktif = true;

            if (kisi.Aktif == true)
            {
                Console.WriteLine("Hoşgeldin " + kisi.Ad);
            }

        }
    }
}
