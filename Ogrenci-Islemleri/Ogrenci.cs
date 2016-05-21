using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW313253039
{
    class Ogrenci
    {
        // private System.Windows.Forms.TextBox bölüm;
        //private System.Windows.Forms.ComboBox derss1;
        //private System.Windows.Forms.ComboBox derss2;
        //private System.Windows.Forms.ComboBox derss3;
        //private System.Windows.Forms.TextBox isim;
        //private System.Windows.Forms.TextBox ogrencino;
        
        //public Ogrenci(System.Windows.Forms.TextBox ogrencino, System.Windows.Forms.TextBox bölüm, System.Windows.Forms.ComboBox derss1, System.Windows.Forms.ComboBox derss2, System.Windows.Forms.ComboBox derss3, System.Windows.Forms.TextBox isim)
        //{
        //    // TODO: Complete member initialization
        //    this.ogrencino = ogrencino;
        //    this.bölüm = bölüm;
        //    this.derss1 = derss1;
        //    this.derss2 = derss2;
        //    this.derss3 = derss3;
        //    this.isim = isim;
        //}
       public string ogrno;
       public string ad;
       public string bolum;
       public string ders1;
        public string ders2;
        public string ders3;
       public string ders1sonuc;
        public string ders2sonuc;
       public string ders3sonuc;
      
        public Ogrenci(string ogrnoo,string bölüm,string derss1,string derss2,string derss3,string isim,string derss1sonuc,string derss2sonuc,string derss3sonuc)
        {
            ogrno = ogrnoo;
            ad = isim;
            bolum = bölüm;
            ders1 = derss1;
            ders2 = derss2;
            ders3 = derss3;
            ders1sonuc = derss1sonuc;
            ders2sonuc = derss2sonuc;
            ders3sonuc = derss3sonuc;
 
        }
        public override string ToString()
        {
            return "Ad: "+ad + " " +"No: "+ ogrno + " "+"Bölüm: " + bolum + "  " + ders1sonuc + " " + ders2sonuc + " " + ders3sonuc;
        }
        
    }
    }

