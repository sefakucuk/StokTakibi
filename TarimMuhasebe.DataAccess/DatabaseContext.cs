using MySql.Data.EntityFramework;
using System.Data.Entity;
using TarimMuhasebe.Entities;

namespace TarimMuhasebe.DataAccess
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DatabaseContext : DbContext
    {
        public DbSet<Birim> Birimler { get; set; }
        public DbSet<Cari> Cariler { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<Gelir> Gelirler { get; set; }
        public DbSet<Gider> Giderler { get; set; }
        public DbSet<Kasa> Kasalar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<OdemeTip> OdemeTipleri { get; set; }
        public DbSet<Alis> Alislar { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<SatisDetay> SatisDetaylari { get; set; }
        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<Urun> Urunler { get; set; }

        public DatabaseContext(string connectionString) : base(connectionString)
        {
            //server=localhost;user=root;password=123456;database=db_tarim_muhasebe
            Database.SetInitializer(new MyInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Birim>().ToTable("birimler");
            modelBuilder.Entity<Cari>().ToTable("cariler");
            modelBuilder.Entity<Depo>().ToTable("depolar");
            modelBuilder.Entity<Gelir>().ToTable("gelirler");
            modelBuilder.Entity<Gider>().ToTable("giderler");
            modelBuilder.Entity<Kasa>().ToTable("kasalar");
            modelBuilder.Entity<Kullanici>().ToTable("kullanicilar");
            modelBuilder.Entity<OdemeTip>().ToTable("odeme_tipleri");
            modelBuilder.Entity<Alis>().ToTable("alis");
            modelBuilder.Entity<Satis>().ToTable("satis");
            modelBuilder.Entity<SatisDetay>().ToTable("satis_detay");
            modelBuilder.Entity<Stok>().ToTable("stok");
            modelBuilder.Entity<Urun>().ToTable("urun");

            modelBuilder.Entity<Urun>().Property(x => x.AlisFiyat).HasPrecision(18, 6);
            modelBuilder.Entity<Urun>().Property(x => x.SatisFiyat).HasPrecision(18, 6);
            modelBuilder.Entity<Urun>().Property(x => x.Stopaj).HasPrecision(5, 2);
            modelBuilder.Entity<Urun>().Property(x => x.Kdv).HasPrecision(5, 2);

            modelBuilder.Entity<Alis>().Property(x => x.StopajOrani).HasPrecision(5, 2);
            modelBuilder.Entity<Alis>().Property(x => x.Miktar).HasPrecision(8,2);
            modelBuilder.Entity<Alis>().Property(x => x.BirimFiyat).HasPrecision(18, 6);
            modelBuilder.Entity<Alis>().Property(x => x.ToplamFiyat).HasPrecision(18, 6);
            modelBuilder.Entity<Alis>().Property(x => x.StopajTutar).HasPrecision(18, 6);

            modelBuilder.Entity<Satis>().Property(x => x.ToplamMatrahTutar).HasPrecision(18, 6);
            modelBuilder.Entity<Satis>().Property(x => x.ToplamKdvTutar).HasPrecision(18, 6);

            modelBuilder.Entity<SatisDetay>().Property(x => x.Miktar).HasPrecision(8,2);
            modelBuilder.Entity<SatisDetay>().Property(x => x.BirimFiyat).HasPrecision(18, 6);
            modelBuilder.Entity<SatisDetay>().Property(x => x.Matrah).HasPrecision(18, 6);
            modelBuilder.Entity<SatisDetay>().Property(x => x.KdvOrani).HasPrecision(5, 2);
            modelBuilder.Entity<SatisDetay>().Property(x => x.Kdv).HasPrecision(18,6);

            modelBuilder.Entity<Gelir>().Property(x => x.Tutar).HasPrecision(18, 6);
            modelBuilder.Entity<Gider>().Property(x => x.Tutar).HasPrecision(18, 6);

            modelBuilder.Entity<Kasa>().Property(x => x.AcilisTutar).HasPrecision(18, 6);
            modelBuilder.Entity<Kasa>().Property(x => x.GuncelTutar).HasPrecision(18, 6);

            modelBuilder.Entity<Stok>().Property(x => x.Miktar).HasPrecision(36, 6);

            modelBuilder.Entity<Cari>().Property(x => x.Kod).IsUnicode().IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Cari>().Property(x => x.Unvan).IsRequired().HasMaxLength(150);
            modelBuilder.Entity<Cari>().Property(x => x.VergiNo).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Cari>().Property(x => x.VergiDairesi).HasMaxLength(150);
            modelBuilder.Entity<Cari>().Property(x => x.Yetkili).HasMaxLength(150);
            modelBuilder.Entity<Cari>().Property(x => x.Il).HasMaxLength(150);
            modelBuilder.Entity<Cari>().Property(x => x.Ilce).HasMaxLength(150);
            modelBuilder.Entity<Cari>().Property(x => x.Adres).HasMaxLength(500);
            modelBuilder.Entity<Cari>().Property(x => x.Tel1).HasMaxLength(20);
            modelBuilder.Entity<Cari>().Property(x => x.Tel2).HasMaxLength(20);
            modelBuilder.Entity<Cari>().Property(x => x.Eposta1).HasMaxLength(150);
            modelBuilder.Entity<Cari>().Property(x => x.Eposta2).HasMaxLength(150);
            modelBuilder.Entity<Cari>().Property(x => x.Fax).HasMaxLength(20);

            modelBuilder.Entity<Birim>().Property(x => x.Ad).IsRequired().HasMaxLength(150);
            modelBuilder.Entity<Birim>().Property(x => x.Gosterim).IsRequired().HasMaxLength(20);

            modelBuilder.Entity<Depo>().Property(x => x.Kod).IsUnicode().IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Depo>().Property(x => x.Ad).IsRequired().HasMaxLength(150);
            modelBuilder.Entity<Depo>().Property(x => x.Aciklama).HasMaxLength(500);

            modelBuilder.Entity<Gelir>().Property(x => x.Kod).IsUnicode().IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Gelir>().Property(x => x.Kullanici).IsRequired().HasMaxLength(150);
            modelBuilder.Entity<Gelir>().Property(x => x.Aciklama).HasMaxLength(500);

            modelBuilder.Entity<Gider>().Property(x => x.Kod).IsUnicode().IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Gider>().Property(x => x.Kullanici).IsRequired().HasMaxLength(150);
            modelBuilder.Entity<Gider>().Property(x => x.Aciklama).HasMaxLength(500);

            modelBuilder.Entity<Kasa>().Property(x => x.Kod).IsUnicode().IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Kasa>().Property(x => x.Ad).IsRequired().HasMaxLength(150);
            modelBuilder.Entity<Kasa>().Property(x => x.Aciklama).HasMaxLength(500);

            modelBuilder.Entity<Kullanici>().Property(x => x.Ad).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Kullanici>().Property(x => x.Soyad).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Kullanici>().Property(x => x.Eposta).IsUnicode().IsRequired().HasMaxLength(150);
            modelBuilder.Entity<Kullanici>().Property(x => x.Telefon).HasMaxLength(20);
            modelBuilder.Entity<Kullanici>().Property(x => x.Sifre).IsRequired().HasMaxLength(500);

            modelBuilder.Entity<OdemeTip>().Property(x => x.Ad).IsRequired().HasMaxLength(50);

            modelBuilder.Entity<Satis>().Property(x => x.Kod).IsUnicode().IsRequired().HasMaxLength(150);
            modelBuilder.Entity<Satis>().Property(x => x.Kullanici).IsRequired().HasMaxLength(150);
            modelBuilder.Entity<Satis>().Property(x => x.Aciklama).HasMaxLength(500);

            modelBuilder.Entity<Alis>().Property(x => x.Kod).IsUnicode().IsRequired().HasMaxLength(150);
            modelBuilder.Entity<Alis>().Property(x => x.Kullanici).IsRequired().HasMaxLength(150);
            modelBuilder.Entity<Alis>().Property(x => x.Aciklama).HasMaxLength(500);

            modelBuilder.Entity<SatisDetay>().Property(x => x.Aciklama).HasMaxLength(500);

            modelBuilder.Entity<Urun>().Property(x => x.Kod).IsUnicode().IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Urun>().Property(x => x.Ad).IsRequired().HasMaxLength(150);

            base.OnModelCreating(modelBuilder);
        }
    }
}
