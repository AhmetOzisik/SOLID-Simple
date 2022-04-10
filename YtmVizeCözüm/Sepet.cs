using System;
using System.Collections.Generic;
using System.Text;

namespace YtmVizeCözüm
{
   public class Sepet
    {
       private List<Urun> uruns = new List<Urun>();
       
        public static int toplam;
        public void SepeteEkle(Urun urun)
        {
            uruns.Add(urun);
           
        }
        public int Odeme()
        {
            foreach ( var fiyat in uruns)
            {
                toplam = toplam + fiyat.Price;
            }
            return toplam;
        }
    }
}
