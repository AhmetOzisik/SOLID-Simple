using System;
using System.Collections.Generic;
using System.Text;

namespace YtmVizeCözüm
{
    public class UrunGoruntule
    {
        public enum İzin
        {
            Customer,
            Seller
        }
       public void UrunGoruntulee(Urun urun,İzin izin,Seller seller )
        {
            switch (izin)
            {
                case İzin.Customer:
                    Console.WriteLine("Urun Adi:"+" "+urun.UrunName+" "+"Urun Fiyat:"+" "+urun.Price);
                    break;
                case İzin.Seller:
                    Console.WriteLine("Urun Adi:" + " " + urun.UrunName + " " + "Urun Fiyat:" + " " + urun.Price+" "+"Firma Ad"+" "+" Firma Adres:"+seller.sellerAdres.İl);
                    break;
                default:
                    Console.WriteLine("Geçersiz!!!!");
                    break;
            }
        }
    }
}
