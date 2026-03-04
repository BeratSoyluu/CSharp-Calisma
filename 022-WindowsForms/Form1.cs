using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 All Windows Forms: Visual Studio'daki tüm görsel araçların alfabetik sırayla listelendiği yerdir. Hangi kategoride olduğunu unuttuğun bir aracı hızlıca bulmak için burayı kullanabilirsin.

Common Controls (Sık Kullanılan Kontroller): Form tasarımında en çok ihtiyaç duyacağın temel yapı taşları buradadır. Kullanıcının tıklayacağı Button, metin gireceği TextBox, bilgi göstereceğin Label veya seçenek sunacağın CheckBox gibi araçları burada bulabilirsin.

Containers (Taşıyıcılar / Gruplayıcılar): Diğer araçları içine koyarak ekranı daha düzenli hale getirmene yarayan araçlardır. Örneğin, bir kayıt formundaki "Kişisel Bilgiler" kısmını bir çerçeve içine almak için GroupBox veya sekmeli yapılar oluşturmak için TabControl kullanabilirsin.

Menus & Toolbars (Menüler ve Araç Çubukları): Tıpkı şu an kullandığın Visual Studio'nun en üstündeki "File, Edit, View" gibi açılır menüler (MenuStrip) veya alt kısımdaki durum bilgi çubukları (StatusStrip) eklemek için kullanılır.

Data (Veri): Veritabanından çektiğin bilgileri ekranda göstermek ve yönetmek için kullanılan araçlardır. Özellikle SQL tablolarındaki verileri ekranda excel gibi listelemek için kullanılan DataGridView aracı, veritabanı projelerinde en büyük yardımcın olacak.

Components (Bileşenler): Formun üzerinde görsel olarak yer kaplamayan ama arka planda çalışan araçlardır. Örneğin, her 1 saniyede bir işlem yapmanı sağlayan Timer veya uzun süren işlemleri arayüzü dondurmadan arka planda çalıştıran BackgroundWorker buradadır.

Printing (Yazdırma): Uygulamana yazıcıdan çıktı alma, sayfa ayarları yapma veya baskı önizleme (PrintPreviewDialog) gibi özellikler eklemek istediğinde kullanacağın hazır araçlardır.

Dialogs (İletişim Kutuları): Windows'un o bildiğimiz standart pencerelerini uygulamana hazır olarak ekler. Kullanıcıdan bir dosya seçmesini istemek için OpenFileDialog, bir şeyi kaydetmesi için SaveFileDialog veya renk seçmesi için ColorDialog gibi pencereleri sıfırdan kodlamak yerine buradan çekip kullanırsın.

WPF Interoperability: C#'ta Windows Forms'tan daha modern bir arayüz teknolojisi olan WPF (Windows Presentation Foundation) ile geliştirilmiş bileşenleri, bu eski tarz formların içine gömmek için kullanılan bir köprüdür. (Büyük ihtimalle şu aşamada burayla pek işin olmayacak).

General (Genel): Burası varsayılan olarak boştur. Kendi yazdığın özel araçları (Custom Controls) veya dışarıdan indirdiğin kütüphaneleri sürükleyip bırakabileceğin kişisel alanındır.
 */


namespace _022_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            //form2.Show(); // form2 penceresini göster.
            form2.ShowDialog(); // form2 yi kapatmadan form1 e döndürmüyor.
            this.Hide(); // pencere kapatılıyor ama uygulamada arkada çalışmaya devam ediyo
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // form ekranında mouse ile çift tıklayarak oluşturuldu.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // ilgili pencereyi kapat
            //Form1.ActiveForm.Close(); // Böyle de kapatabiliyoruz.
        }
    }
}
