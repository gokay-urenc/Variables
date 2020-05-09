using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tam Sayı Veri Tipleri
            byte byt = 168;
            sbyte sbyt = -111;
            short shr = -1624;
            ushort ushr = 4223;
            int integer = -523536225;
            uint uinteger = 523525252;
            long lng = -52356236236952353;
            ulong ulng = 85523325522525523;
            // Ondalıklı Sayı Veri Tipleri
            double dbl = 9.7;
            float flt = 5.6f;
            decimal dcml = 3.4m;
            // Metinsel Veri Tipleri
            string str = "Hello World.";
            char chr = 'c';
            // Mantıksal Veri Tipi
            bool bl = true;
            // Tarihsel Veri Tipi
            DateTime dt = DateTime.Now;
            // Kullanıcının adını, soyadını, yaşını, cinsiyet bilgisini, evli mi bekar mı bilgilerini tutan değişkenleri tanımlayın.
            string ad = "Negan", soyad = "Lucille";
            byte yas = 48;
            char cns = 'E';
            bool mdn = false;
            Console.Write(ad + "\n" + soyad + "\n" + yas + "\n" + cns + "\n" + mdn);
            Console.ReadKey();
        }
    }
}
/* Tam sayı veri tipleri: byte, sbyte, short, ushort, int, uint, long, ulong
   Değişken tanımlama: <veri tipi> <değişken ismi> = <atanacak değer;>
   Bir değişken adı asla iki kelimeden oluşmaz. İki kelimelik bir değişken ismi oluşturuluyorsa
   aralarında boşluk bırakılmaz.
   Değişken tanımlamasında _ dışında özel karakter kullanılmaz.
   Değişkenlere veri tipine göre değer atanmalıdır.
   Float veri tipine atanan değişkenin sonuna f ya da F konmazsa hata verir. Bunun yapılması veri tipinin
   double olarak algılanmamasını sağlar. Veri tipinin double değilde float olduğunu belirtmeye yarar.
   Aynı durum decimal veri tipi içinde geçerlidir. Sonuna m ya da M konmalıdır. m, Moneyin kısaltmasıdır.
   Parasal işlerde tercih edilen veri tipidir. C#'ın en büyük veri tipidir.
   String ifade sonsuz karakter barındırabilir.
   Char tek bir karakter barındırabilir. String veri tipinin aksine tek tırnak içine yazılır.
   Bool veri tipi sadece true ya da false değerlerinden birini alabilir.
   = işareti atama operatörüdür. Atama operatöründe kural sağdaki değer ile soldaki değerin veritipi birbirine eşit olmalıdır.
*/