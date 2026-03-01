using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Varsayılan olarak, bir arayüzün üyeleri abstract ve public şeklindedir.
// Arayüz metotlarına erişmek için, arayüzün başka bir sınıf tarafından "uygulanması" (bir nevi miras alınması) gerekir. Bir arayüzü uygulamak için, tıpkı miras alma işleminde olduğu gibi, : sembolünü kullanın. Arayüz metodunun gövdesi, "uygulayan" sınıf tarafından sağlanır. Bir arayüzü uygularken override anahtar kelimesini kullanmak zorunda olmadığınızı unutmayın.
// interface de imzası tanımlanan metodun yapacağı iş class da belirlenir.
/*
 Arayüzler Neden ve Ne Zaman Kullanılır?
       1) Güvenliği sağlamak için - belirli ayrıntıları gizleyip yalnızca nesnenin (arayüzün) önemli ayrıntılarını göstermek için.
       2) C# "çoklu kalıtımı" desteklemez (bir sınıf yalnızca bir temel sınıftan miras alabilir). Ancak, sınıf birden fazla arayüzü uygulayabildiği için bu, arayüzler ile sağlanabilir. Not: Birden fazla arayüzü uygulamak için bunları virgülle ayırın.*/

namespace _018_Interface_AraYuzler
{
    interface OrnekArayuz
    {
        int MyProperty { get; set; } // Arayüz içinde property kullanabiliyoruz.
    }
    //******************************************************************************************
    interface Idemo
    {
        void Goster(); // Interface lerde sadece metot imzaları yer alır, metotolar bu interface den miras alan class larda kullanılır.
    }
    //******************************************************************************************
    interface Inokta
    {
        // Properties imzası
        int x { get; set; }
        int y { get; set; }
    }
    // Inokta arayüzünü implemente eden sınıfımız
    class Nokta : Inokta
    {
        private int _x { get; set; }
        private int _y { get; set; }
        public int x { get { return _x; } set { _x = value; } }
        public int y { get { return _y; } set { _y = value; } }
    }
    //******************************************************************************************
    interface icerebilecekleri : Idemo
    {
        // Bir interface in içerebileceği özellikler
        //public int MyProperty { get; set; } bir interface içeriisnde prop tab ile property eklersek başındaki public ifadesini kaldırmak zorundayız çünkü interface ler erişim belirteci almaz daima public tir.
        int MyProperty { get; set; } // interface ler erişim belirteçsiz property leri barındırabilir.
        // static int MyProperty2 { get; set; } intereface ler static tanımlanamaz.
        void MesajVer(); // interface ler metot imzalarını barındırabilir.
    }
    interface iceremedikleri : Idemo
    {
        //string metin; interface içinde değişken kullanamaz.
        // interface ler class lardaki kurucu metotları kullanamaz.
        int CikarmaYap(int sayi1, int sayi2); // interface ler parametreli metot imzası alabilir.
        //int CikarmaYap2(int sayi1, int sayi2) { return sayi1 - sayi2} interface ler içinde metotoların yapacağı işler tanımlanmaz.

    }
    class ArayuzKullanimi : icerebilecekleri, iceremedikleri
    {
        public int MyProperty { get; set; }

        public int CikarmaYap(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        public void Goster()
        {
            Console.WriteLine("interface de imzası tanımlanan metodun yapacağı iş class da belirlenir.");
        }

        public void MesajVer()
        {
            Console.WriteLine("merhaba");
        }
    }
    //******************************************************************************************
    interface ISinifGereksinimleri
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateTime CreateDate { get; set; }
        DateTime ChangeDate { get; set; }
    }
    class Kategori : ISinifGereksinimleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }
    }
    class Urun : ISinifGereksinimleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }
        public decimal Price { get; set; }
    }
    class Marka : ISinifGereksinimleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
