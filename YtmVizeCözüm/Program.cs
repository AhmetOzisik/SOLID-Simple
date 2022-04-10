using System;

namespace YtmVizeCözüm
{
    class Program
    {
        static void Main(string[] args)
        {
            VeriTabani veriTabani = VeriTabani.veritabaniolustur();
            IVeriTabanı veriTabanı = veriTabani.AsılVeriTabanı(new SqlVerİTabanı());

            Customer customer = new Customer();
            customer.Name = "Ahmet";
            customer.Mail = "aozisik07@icloud.com";
            customer.Sifre = 123456;
            customer.customerAdres = new CustomerAdres { İl = "Bursa", İlce = "Osmangazi" };


            Seller seller = new Seller();
            seller.FirmaAd = "Aksulu";
            seller.Mail = "aksulukavafiye@hotmail.com";
            seller.Sifre = 1234567;
            seller.sellerAdres = new SellerAdres { İl = "Bursa", İlce = "Osmangazi" };

            veriTabanı.MusteriEkle(customer);
            veriTabanı.SaticiEkle(seller);
            Urun urun = new Urun();
            urun.UrunName = "Panduf";
            urun.Price = 70;
            Urun urun2 = new Urun();
            urun2.UrunName = "Panduf";
            urun2.Price = 80;
           
          
            UrunService urunService = new UrunService();
            urunService.UrunEkle(urun,UrunService.Tip.Seller);
            UrunGoruntule urunGoruntule = new UrunGoruntule();
            urunGoruntule.UrunGoruntulee(urun, UrunGoruntule.İzin.Seller,seller);
            urunGoruntule.UrunGoruntulee(urun2, UrunGoruntule.İzin.Customer);
            Sepet sepet = new Sepet();
            sepet.SepeteEkle(urun);
            sepet.SepeteEkle(urun2);
            int toplamodeme = sepet.Odeme();
            Console.WriteLine(sepet.Odeme());
            veriTabanı.YapılanÖdeme(toplamodeme,customer);
            
            

        }
    }
}
