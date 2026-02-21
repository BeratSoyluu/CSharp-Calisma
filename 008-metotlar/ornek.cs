using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_metotlar
{
    internal class ornek
    {
        static bool MailGonder(string mailAdres)
        {
            if (!string.IsNullOrWhiteSpace(mailAdres)) // Eğer mailAdres değişkenine bir deper girilmişse, yani mailAdres boş değilse
            {
                return true;
            }
            else return false;
        }
        static void Main(string[] args)
        {
            Console.Write("Lütfen mail adresi giriniz: ");
            var email = Console.ReadLine();
            if(MailGonder(email) == false)
            {
                Console.WriteLine("Mail adresi boş geçilmez!");
            }
            else Console.WriteLine("Mail kabul edildi");
        }
    }
}
