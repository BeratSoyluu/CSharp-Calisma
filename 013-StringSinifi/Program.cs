using System;

namespace _013_StringSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken;
            char karakter;
            string metinlericin = "metin yazısı";
            Console.WriteLine(metinlericin);

            Ornek1();
            Kiyasla();
        }

        static void Ornek1()
        {
            string birMetin = "Ankara başkenttir.";
            String birSayi = "123456789";
            System.String birTarih = "26.02.2026";
            string s = "Barış Manço";

            for(int i=0; i< s.Length; i++)
            {
                Console.WriteLine("s[" + i + "] = " + s[i]);
            }
            Console.WriteLine("**********************************************************************************************************");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine(birMetin.GetType());
            Console.WriteLine(birSayi.GetType());
            Console.WriteLine(birTarih.GetType());

        }

        static void StringMetotlar()
        {
            Console.WriteLine("**********************************************************************************************************");
            string metin = "Hi My name is Slim Shady";
            var result = metin.Length; // metin değişkeninin uzunluğunu verir.
            var result2 = metin.Clone(); // metin değişkenini kopyalar.
            
            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD" (txt değişkeninin içindeki harfleri büyük harfe çevirir.)
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"(txt değişkeninin içindeki harfleri küçük harfe çevirir.)

            metin = "My name is Ali/";
            bool result3 = metin.EndsWith("a"); // metin 'a' ile bitiyor mu?
            bool result4 = metin.StartsWith("My name"); // metin 'My name' ile başlıyor mu?

            var result5 = metin.IndexOf("namee"); // indexof metodu metin içerisinde aradığımız karakteri bulmazsa geriye -1 döndürür.
            var result6 = metin.IndexOf(" "); // // indexof metodu metin içerisinde aradığımız karakteri bulursa geriye kartakterin index numarasını döndürür.
            var resul7 = metin.LastIndexOf("/"); // metin değişkeni içindeki en son geçen "/" (slash) karakterinin bulunduğu sırayı (indeksi) bulup resul7 değişkenine kaydeder.
            var result8 = metin.Insert(0, "Hello, "); // metin değişkeninin en başına (0. indekse) "Hello" kelimesini ekler ve oluşan yeni metni result8 değişkenine kaydeder.
            var result9 = metin.Substring(3, 4); // metin değişkeninin 3. indeksinden (yani 4. sıradan) başlayarak 4 karakter uzunluğundaki kısmı kopyalayıp result9 değişkenine kaydeder.
            var result10 = metin.Replace(" ", "-"); // metin değişkeni içindeki tüm boşluk karakterlerini (" ") bulup, yerlerine tire ("-") işareti koyarak sonucu result10 değişkenine kaydeder.
            var result11 = metin.Remove(2, 5); // metin değişkeninin 2. indeksinden (yani 3. sıradan) başlayarak 5 karakteri silip atar ve geriye kalan metni result11 değişkenine kaydeder.
            // Stirng sınıfına bir değer ataması yapmazsak varsayılan değeri null olur.
            // String referans tiplidir. Diğer değişken veri tipleri değer tiplidir.
            // String nesnedir, değiştirilemez. Bildirimi yapılan bir string üzerine bir değişiklil yapılırsa bu değişiklik arka tarafa başka bir string oluşmasına sebep olur.

        }

        static void Kiyasla()
        {
            string kelime1 = "Ankara";
            string kelime2 = "İstanbul";
            string kelime3 = "ANKARA";
            string kelime4 = "Ankara";

            Console.WriteLine(kelime1 == kelime2);
            Console.WriteLine(kelime1 != kelime2);
            Console.WriteLine(kelime1 == kelime4);
            Console.WriteLine(kelime1 == kelime3);

            Console.WriteLine("Ankara" == "ANKARA");
            Console.WriteLine("Ankara" != "ANKARA");
        }
    }
}
