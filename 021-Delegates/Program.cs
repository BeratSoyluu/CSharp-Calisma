using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_Delegates
{
    using System;

    class OdemeSistemi
    {
        // 1. Adım: Delegate Tanımlama (Hazır 'Action' kullanıyoruz)
        // Action<decimal> -> Geriye bir şey döndürmeyen, sadece 'decimal' (tutar) alan metotları tutar.
        public Action<decimal> OnOdemeTamamlandi;

        public void OdemeYap(decimal tutar)
        {
            Console.WriteLine($"{tutar} TL tutarındaki ödeme işleniyor...");
            System.Threading.Thread.Sleep(1000); // İşlem süresi simülasyonu

            Console.WriteLine("Ödeme başarıyla tamamlandı!");

            // 2. Adım: Delegate tetikleniyor (İçine bağlı tüm metotlar çalışacak)
            if (OnOdemeTamamlandi != null)
            {
                OnOdemeTamamlandi(tutar);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            OdemeSistemi servis = new OdemeSistemi();

            // 3. Adım: Metotları delegate'e bağlıyoruz (Metot imzaları aynı olmalı!)
            servis.OnOdemeTamamlandi += LogKaydet;
            servis.OnOdemeTamamlandi += SmsGonder;
            servis.OnOdemeTamamlandi += MuhasebeMailAt;

            // Sistemi çalıştırıyoruz
            servis.OdemeYap(1550.75m);

            Console.WriteLine("\n--- Bir metodu listeden çıkarıyoruz (SMS iptal) ---");
            servis.OnOdemeTamamlandi -= SmsGonder;

            servis.OdemeYap(200.00m);
        }

        // Bağlanacak Metotlar:
        static void LogKaydet(decimal miktar) =>
            Console.WriteLine($"[LOG]: {miktar} TL değerinde işlem kaydedildi.");

        static void SmsGonder(decimal miktar) =>
            Console.WriteLine($"[SMS]: Sayın müşterimiz, {miktar} TL harcamanız onaylandı.");

        static void MuhasebeMailAt(decimal miktar) =>
            Console.WriteLine($"[MAIL]: Muhasebe Birimi: {miktar} TL yeni ödeme girişi yapıldı.");
    }
}
