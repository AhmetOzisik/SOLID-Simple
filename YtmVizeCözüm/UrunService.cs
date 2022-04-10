using System;
using System.Collections.Generic;
using System.Text;

namespace YtmVizeCözüm
{
    public class UrunService
    {
       public enum Tip
        {
            Seller,
            Costumer
        }
        public void UrunEkle(Urun urun,Tip tip)
        {
            switch (tip)
            {
                case Tip.Seller:
                     Console.WriteLine("ürün eklendi");
                    break;
                case Tip.Costumer:
                     Console.WriteLine("Ürün ekleme yetkiniz yoktur.");
                    break;
                default:
                    Console.WriteLine("Geçersiz ürün ekleme işlemi yapilmadi.");
                    break;

            }
        }
    }
}

