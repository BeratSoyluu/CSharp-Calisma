using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_Polimorfizm
{
    // 1. Üst Sınıf (Base Class)
    public class Hayvan
    {
        public virtual void SesCikar() // 'virtual' diyerek bu metodun alt sınıflarda değişebileceğini belirtiyoruz.
        {
            Console.WriteLine("Hayvan genel bir ses çıkardı.");
        }
    }

    // 2. Alt Sınıf - Kopek (Override Eden)
    public class Kopek : Hayvan
    {
        public override void SesCikar() // 'override' ile üst sınıftaki metodu eziyoruz (yeniden yazıyoruz).
        {
            Console.WriteLine("Hav Hav!");
        }
    }

    // 3. Alt Sınıf - Kedi (Override Eden)
    public class Kedi : Hayvan
    {
        public override void SesCikar() // 'override' ile üst sınıftaki metodu eziyoruz (yeniden yazıyoruz).
        {
            Console.WriteLine("Miyav!");
        }
    }

    // 4. Alt Sınıf - Balik (Override ETMEYEN)
    public class Balik : Hayvan
    {
        // Balık sınıfı SesCikar metodunu override etmedi.
        // Dolayısıyla Hayvan sınıfındaki varsayılan metodu kullanacak.
    }

    class Program
    {
        static void Main()
        {
            Hayvan[] sesicikar = new Hayvan[3];
            sesicikar[0] = new Kopek();
            sesicikar[1] = new Kedi();
            sesicikar[2] = new Balik();

            foreach(var item in sesicikar)
            {
                item.SesCikar();
            }
        }
    }
}
