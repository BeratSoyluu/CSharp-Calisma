using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 ile 12 arasında bir sayı giriniz: ");
            int ay = Convert.ToInt32(Console.ReadLine());

            switch (ay)
            {
                case 12: // Eğer ay 12 ise aşağı bak...
                case 1:  // Eğer ay 1 ise aşağı bak...
                case 2:  // Eğer ay 2 ise...
                    Console.WriteLine("Kış mevsimi"); // Buradaki kodu çalıştır.
                    break; // Switch'ten çık.
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimi");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimi");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimi");
                    break;

                default:
                    Console.WriteLine("Yanlış bilgi.");
                    break;
            }
        }
    }
}
