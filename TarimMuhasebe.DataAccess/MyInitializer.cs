using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarimMuhasebe.Entities;

namespace TarimMuhasebe.DataAccess
{
    public class MyInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            Kullanici kullanici = new Kullanici
            {
                Ad = "teknosivas",
                Soyad = "admin",
                Eposta = "admin@teknosivas.com",
                Sifre = "teknosivas",
                Aktif = true,
                Yonetici = true
            };

            context.Kullanicilar.Add(kullanici);

            OdemeTip tip1 = new OdemeTip
            {
                Ad = "Nakit"
            };
            OdemeTip tip2 = new OdemeTip
            {
                Ad = "Kredi Kartı"
            };
            OdemeTip tip3 = new OdemeTip
            {
                Ad = "Çek-Senet"
            };
            OdemeTip tip4 = new OdemeTip
            {
                Ad = "Vadeli"
            };

            context.OdemeTipleri.Add(tip1);
            context.OdemeTipleri.Add(tip2);
            context.OdemeTipleri.Add(tip3);
            context.OdemeTipleri.Add(tip4);

            Depo depo = new Depo
            {
                Kod = "00001",
                Ad = "Merkez"
            };

            context.Depolar.Add(depo);

            Birim birim1 = new Birim
            {
                Ad = "Adet",
                Gosterim = "Adet"
            };
            Birim birim2 = new Birim
            {
                Ad = "Kilogram",
                Gosterim = "KG"
            };

            context.Birimler.Add(birim1);
            context.Birimler.Add(birim2);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
