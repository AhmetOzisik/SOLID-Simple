using System;
using System.Collections.Generic;
using System.Text;

namespace YtmVizeCözüm
{
    public class SqlVerİTabanı : IVeriTabanı
    {
        public void MusteriEkle(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + "isimli kullanıcı veritabanına eklendi.");
        }

        public void SaticiEkle(Seller seller)
        {
            Console.WriteLine(seller.FirmaAd + " " + "isimli firma veritabanına eklendi.");
        }

        public void UrunEkle(Urun urun)
        {
            Console.WriteLine(urun.UrunName + "" + "isimli urun veritabanına eklendi.");
        }

        public void YapılanÖdeme(int Odeme,Customer customer)
        {
            Console.WriteLine(customer.Name + " " + " isimli kullanicinin"+" " + Odeme + " " + "TL lik odemesi veri tabanına kaydedilmiştir.");
        }
    }
}
