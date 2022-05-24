using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UfukEmreTeğmen
{
   public class kaydet
    {
       /* string bilet; bu şekilde yaptığım zaman ucak sınıfında bağımsız değişken yok hatası alıyorum o yüzden get set kullandım.
        string kSehir; yine de bu satırlarıda denediğim için silmek istemedim.
        string vSehir;
        string kSaat;
        string hSaat;
        string bTip;
        string dSayısı;
        int fiyat;
       */
       public string bilet { get; set; }
        public string kSehir { get; set; }
        public string vSehir { get; set; }
        public string kSaat { get; set; }
        public string hSaat { get; set; }
        public string dSayısıs { get; set; } 
        public int fiyat { get; set; }
        /*public kaydet(string bilet, string kSehir, string vSehir, string kSaat, string hSaat, string dSayısı, int fiyat)
        {
            this.bilet = bilet;
            this.kSehir = kSehir;
            this.vSehir = vSehir;
            this.kSaat = kSaat;
            this.hSaat = hSaat;
            this.dSayısı = dSayısı;
            this.fiyat = fiyat;
        
        
        }*/
        public string[] liste()
        {

            string[] save = { bilet, kSehir, vSehir, kSaat, hSaat, dSayısıs, fiyat.ToString() };
            return save;

        }
    }
    
}
