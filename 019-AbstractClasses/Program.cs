using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Veri soyutlama, belirli ayrıntıları gizleme ve kullanıcıya yalnızca temel bilgileri gösterme işlemidir.
/*
`abstract` anahtar kelimesi sınıflar ve metotlar için kullanılır:
    Soyut sınıf: Nesne oluşturmak için kullanılamayan kısıtlı bir sınıftır (erişim için başka bir sınıftan miras alınması gerekir).
    Soyut metot: Yalnızca soyut bir sınıfta kullanılabilir ve gövdesi yoktur. Gövde, türetilmiş sınıf (miras alınan sınıf) tarafından sağlanır.
Soyut bir sınıf hem soyut hem de normal metotlara sahip olabilir.
*/


namespace _019_AbstractClasses
{
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Ekleme başarılı!");
        }
        public abstract void Delete(); // Metoto imzası oluşturulabilir.
        public abstract void Update();
        public abstract void Get();
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Kayıt sql server dan silindi!");
        }

        public override void Get()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Kayıt Oracle dan silindi!");
        }

        public override void Get()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
    class Mysql : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Kayıt mysql den silindi!");
        }

        public override void Get()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add();
            database.Delete();
            Database sql = new SqlServer();
            sql.Add();
            sql.Delete();
        }
    }
}
