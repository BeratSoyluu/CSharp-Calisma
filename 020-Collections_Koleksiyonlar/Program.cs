using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Collections (Koleksiyonlar), verileri bir arada tutan, yöneten, sıralayan veya filtreleyen gelişmiş yapı dizileridir.
// Koleksiyonlar ise dinamiktir; içine veri ekledikçe kendi kendine büyür, sildikçe küçülür.

namespace _020_Collections_Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek1();
            Console.WriteLine("*****************************");
            Ornek2();
            Console.WriteLine("*****************************");
            Ornek3();
            Console.WriteLine("*****************************");
            Ornek4();
            Console.WriteLine("*****************************");
            Ornek5();
            Console.WriteLine("*****************************");
            Ornek6();
            Console.WriteLine("*****************************");
            Ornek7();
            Console.WriteLine("*****************************");
            Ornek8();
        }
        static void Ornek1()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(12);
            arrayList.Add(15);
            arrayList.Add(18);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(arrayList[1]);
        }
//******************************************************************************************************************************************
        static void Ornek2()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("İzmir");
            arrayList.Add("Ankara");
            arrayList.Add("İstanbul");
            Console.WriteLine("Sıralanmamış liste:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*****************************");
            Console.WriteLine("A dan Z ye Sıralanmış Liste:");
            arrayList.Sort();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*****************************");
            Console.WriteLine("Z den A ya Sıralanmış Liste:");
            arrayList.Reverse();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
//******************************************************************************************************************************************
        static void Ornek3()
        {
            // Kolleksiyonlara farklı veri tiplerinden değer atama
            int tamsayi = 18;
            double dabil = 10.2;
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Başkent Ankara");
            arrayList.Add(tamsayi);
            arrayList.Add(dabil);
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

        }
//******************************************************************************************************************************************
        static void Ornek4()
        {
            StringCollection sc = new StringCollection();
            sc.Add("Ankara");
            sc.Add("İstanbul");
            sc.Add("İzmir"); 
            foreach (var item in sc)
            {
                Console.WriteLine(item);
            }
        }
//******************************************************************************************************************************************
        static void Ornek5()
        {
            StringDictionary stringDictionary = new StringDictionary(); // key ve value atayabiliyoruz.
            stringDictionary.Add("06", "Ankara");
            stringDictionary.Add("", "İstanbul");
            stringDictionary.Add("35", "İzmir");
            // StringDictionary yerine bu yapıyı kullan.
            Dictionary<string, string> sehirler = new Dictionary<string, string>();
            sehirler.Add("06", "Ankara");
            sehirler.Add("34", "İstanbul");
            sehirler.Add("35", "İzmir");
            Console.WriteLine(sehirler["06"]);
            foreach (var item in sehirler)
            {
                Console.WriteLine(item); // item.value --> şehir adları döner.       item.key --> plaka kodları döner.
            }
        }
//******************************************************************************************************************************************
        static void Ornek6()
        {
            Stack<string> sehirYigini = new Stack<string>(); // Son giren ilk çıkar.
            sehirYigini.Push("Ankara");
            sehirYigini.Push("İstanbul");
            sehirYigini.Push("İzmir");
            // Peek() Metodu Notu: 
            // Eğer en üstteki veriyi SİLMEDEN sadece bakmak istersen sehirYigini.Peek() kullanabilirsin.
            while (sehirYigini.Count > 0)
            {
                Console.WriteLine(sehirYigini.Pop()); // stack in üstünden bir öğğe çekmek için pop metodu kullanılır.
            }
        }
//******************************************************************************************************************************************
        static void Ornek7()
        {
            Queue<string> sehirKuyrugu = new Queue<string>();

            // Veri Ekleme: Enqueue (Sıraya gir)
            sehirKuyrugu.Enqueue("Ankara");
            sehirKuyrugu.Enqueue("İstanbul");
            sehirKuyrugu.Enqueue("İzmir");

            while (sehirKuyrugu.Count > 0)
            {
                // Veri Çekme: Dequeue (Sıradan çık)
                // En başta giren "Ankara" ilk önce çıkar.
                Console.WriteLine(sehirKuyrugu.Dequeue());
            }

        }
//******************************************************************************************************************************************
        static void Ornek8()
        {
            // Dictionary<Key, Value> -> Tipini baştan belirliyoruz (Örn: int ve string)
            Dictionary<string, string> hashtableHali = new Dictionary<string, string>();

            hashtableHali.Add("06", "Ankara");
            hashtableHali.Add("34", "İstanbul");
            hashtableHali.Add("35", "İzmir");

            // Anahtarları yazdırma
            Console.WriteLine("Anahtarlar:");
            foreach (string key in hashtableHali.Keys)
            {
                Console.WriteLine(key);
            }

            // Değerleri yazdırma
            Console.WriteLine("Değerler:");
            foreach (string value in hashtableHali.Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
