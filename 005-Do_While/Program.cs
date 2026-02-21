using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 3;
            do // en btaşta şarta bakılmaksızın bir defa kod bloğunu işliyor.
            {
                Console.WriteLine("Do While Sayı {0}", toplam);
                toplam++;
            } while (toplam < 10);
        }
    }
}
