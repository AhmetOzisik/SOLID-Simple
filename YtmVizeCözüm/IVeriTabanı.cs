using System;
using System.Collections.Generic;
using System.Text;

namespace YtmVizeCözüm
{
   public interface IVeriTabanı
    {
       void MusteriEkle(Customer customer);
       void SaticiEkle(Seller seller);
       void UrunEkle(Urun urun);
       void YapılanÖdeme(int Odeme,Customer customer);
    }
}
