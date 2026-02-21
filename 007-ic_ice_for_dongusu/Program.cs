using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_ic_ice_for_dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("i değişkeninin değeri {0}",i);
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine("\tj değişkeninin değeri {0}", j);
                }
            }
        }
    }
}
