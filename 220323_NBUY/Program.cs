using System;
using System.Globalization;

namespace _220323_NBUY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region arac interfacesi ile ucak,araba,otosüb,tren özelliklerini alma
            /*   Araba araba = new Araba() { YakitTipi = "Benzin", CamAcma = true, MaxHiz = 200, YolcuKapasitesi = 5 };
       Ucak ucak = new Ucak() { YakitTipi = "Jet Yakıtı", CamAcma = false, MaxHiz = 1000, YolcuKapasitesi = 150 };
       Otobus otobus = new Otobus() { YakitTipi = "Dizel", CamAcma = true, MaxHiz = 120, YolcuKapasitesi = 50 };
       Tren tren = new Tren() { YakitTipi = "Elektrik", CamAcma = false, MaxHiz = 300, YolcuKapasitesi = 500 };

         Console.WriteLine("Araba özellikleri:");
         Console.WriteLine($"Yakıt Tipi: {araba.YakitTipi}");
         Console.WriteLine($"Cam açma özelliği: {(araba.CamAcma ? "Cam açar" : "Cam açamaz")}");
         Console.WriteLine($"Max Hız: {araba.MaxHiz}");
         Console.WriteLine($"Yolcu Kapasitesi: {araba.YolcuKapasitesi}");
         Console.WriteLine();

         Console.WriteLine("Uçak özellikleri:");
         Console.WriteLine($"Yakıt Tipi: {ucak.YakitTipi}");
         Console.WriteLine($"Cam açma özelliği: {(ucak.CamAcma ? "Cam açar" : "Cam açamaz")}");
         Console.WriteLine($"Max Hız: {ucak.MaxHiz}");
         Console.WriteLine($"Yolcu Kapasitesi: {ucak.YolcuKapasitesi}");
         Console.WriteLine();

         Console.WriteLine("Otobüs özellikleri:");
         Console.WriteLine($"Yakıt Tipi: {otobus.YakitTipi}");
         Console.WriteLine($"Cam açma özelliği: {(otobus.CamAcma ? "Cam açar" : "Cam açamaz")}");
         Console.WriteLine($"Max Hız: {otobus.MaxHiz}");
         Console.WriteLine($"Yolcu Kapasitesi: {otobus.YolcuKapasitesi}");
         Console.WriteLine();

         Console.WriteLine("Tren özellikleri:");
         Console.WriteLine($"Yakıt Tipi: {tren.YakitTipi}");
         Console.WriteLine($"Cam açma özelliği: {(tren.CamAcma ? "Cam açar" : "Cam açamaz")}");
         Console.WriteLine($"Max Hız: {tren.MaxHiz}");
         Console.WriteLine($"Yolcu Kapasitesi: {tren.YolcuKapasitesi}");
         Console.WriteLine();
   }
}
public interface IArac
{
   string YakitTipi { get; set; }
   bool CamAcma { get; set; }
   int MaxHiz { get; set; }
   int YolcuKapasitesi { get; set; }
}
public class Araba : IArac
{
   public string YakitTipi { get; set; }
   public bool CamAcma { get; set; }
   public int MaxHiz { get; set; }
   public int YolcuKapasitesi { get; set; }
}
public class Ucak : IArac
{
   public string YakitTipi { get; set; }
   public bool CamAcma { get; set; }
   public int MaxHiz { get; set; }
   public int YolcuKapasitesi { get; set; }
}
public class Otobus : IArac
{
   public string YakitTipi { get; set; }
   public bool CamAcma { get; set; }
   public int MaxHiz { get; set; }
   public int YolcuKapasitesi { get; set; }
}

public class Tren : IArac
{
   public string YakitTipi { get; set; }
   public bool CamAcma { get; set; }
   public int MaxHiz { get; set; }
   public int YolcuKapasitesi { get; set; }
}*/
            #endregion

            #region Interface kullanımı aile yazma örnek
            /*   baba b1 = new baba();
                b1.Biyik = true;
                baba b2 = new baba() { Biyik = false };
                Console.WriteLine($"Bıyık özelliği: {(b1.Biyik ? "Bıyıklı" : "Bıyıksız")}");
                Console.WriteLine($"Bıyık özelliği: {(b2.Biyik ? "Bıyıklı" : "Bıyıksız")}");

            }
        }
        public class kisi
        {
            public int Id { get; set; }
            public string ad { get; set; }
            public string soyad { get; set; }
            public byte yas { get; set; }

        }
        interface IErkek
        {
            public bool Biyik { get; set; }
        }
        class baba:OyKullanabilme,IErkek
        {
            public decimal maas { get; set; }
            public bool Biyik { get ; set; }
        }
        interface IKadın
        {
            public bool tesettur { get; set; }
        }
        class anne : IKadın
        {
            public bool tesettur { get; set; }
        }
        class OyKullanabilme
        {
            public void Oykullan(int yas)
            {
                if (yas>18)
                {
                    Console.WriteLine("OY ATAR");
                }
               else
                {
                    Console.WriteLine("OY ATAMAZ");
                }
            }
        }*/
            #endregion

            #region Satıcı, Alıcı, Ürün, Kargo Taşıma aracı interface ve metotlar ile belirlenen özellikleri yazdıran örnek
            /* satici st = new satici() { ad = "fatma", soyad = "can", bolge = "Türkiye" };
             alici al = new alici() { ad = "berk", soyad = "kayayosunu" };
             urun u1 = new urun() { tur = "yiyecek", ad = "Aysekadin Fasulye", fiyat = 500, kilo = 5, };
             Console.WriteLine("Ürünün:");
             Console.WriteLine($"Adı:{u1.ad} Türü:{u1.tur} Fiyatı:{u1.fiyat} Kilosu:{u1.kilo} ürün satmıştır.");

             kargocu k1 = new kargocu();
             k1.tasimakapasitesi(u1);

         }
     }
     class satici : Ikisi
     {
         public int id { get; set; }
         public string ad { get; set; }
         public string soyad { get; set; }

         public int vergiNumarasi { get; set; }
         public string bolge { get; set; }
         public string tcNo { get; set; }
     }
     class alici : Ikisi
     {
         public int id { get; set; }
         public string ad { get; set; }
         public string soyad { get; set; }
     }
     interface Itasiyabilirlik
     {
         public void tasimakapasitesi(urun urn)
         {
             if (urn.kilo > 20)
             {
                 Console.WriteLine("Araç Kamyondur.");
             }
             else if (urn.kilo > 5)
             {
                 Console.WriteLine("Araç kamyonettir.");
             }
             else
             {
                 Console.WriteLine("Araç motosiklettir.");
             }
         }
     }
     internal class kargocu : Ikisi, Itasiyabilirlik
     {
         public int id { get; set; }
         public string ad { get; set; }
         public string soyad { get; set; }
         public string bolge { get; set; }
         public string tcNo { get; set; }
         public Arac araci { get; set; }
         public void tasimakapasitesi(urun urn)
         {
             if (urn.kilo > 20)
             {
                 Console.WriteLine("Taşınacak Araç Kamyondur.");
             }
             else if (urn.kilo > 5)
             {
                 Console.WriteLine("Taşınacak Araç kamyonettir.");
             }
             else
             {
                 Console.WriteLine("Taşınacak Araç motosiklettir.");
             }
         }
     }
     class Arac
     {
         public static string aracturu { get; set; }
     }
     class urun
     {
         public string tur { get; set; }
         public int fiyat { get; set; }
         public string ad { get; set; }
         public int kilo { get; set; }
     }
     interface Ikisi
     {
         public int id { get; set; }
         public string ad { get; set; }
         public string soyad { get; set; }
     } */
            #endregion

            #region silah ve ates etme örnek cozumu
            /*silah M4A1 = new silah();
    oyuncu player1 = new oyuncu() { ad = "gerard", nickname = "noKiss", silahi= M4A1, yas = 21 };
    Console.WriteLine(player1.ad+" "+player1.nickname+" "+player1.silahi+" "+player1.yas);*/

            // Yeni oyuncu oluştur
            /* oyuncu o1 = new oyuncu();
             o1.ad = "Ali";
             o1.nickname = "sniper";
             o1.yas = 25;
             o1.silahi = new ateslisilahlar(); // ateşli silah kullanacağız
             o1.silahi.maxmermi = 20; // şarjördeki maksimum mermi sayısı
             o1.silahi.mermisayisi = 20; // başlangıçta şarjördeki mermi sayısı

             // Nişan al
             o1.NisanAl();

             // Saldırı yap
             o1.saldır();

             // Sonuçları ekrana yazdır
             Console.WriteLine("Kalan mermi sayısı: " + o1.silahi.mermisayisi);
             Console.WriteLine("Kalan can: " + o1.can);*/

            /*   ateslisilahlar silah = new ateslisilahlar
               {
                   vurusgucu = 10,
                   agirlik = 2.5,
                   mesafe = 100,
                   maxmermi = 20,
                   mermisayisi = 10
               };

               oyuncu oyuncu1 = new oyuncu
               {
                   ad = "Ahmet",
                   nickname = "Ahmet123",
                   yas = 25,
                   silahi = silah
               };

               oyuncu1.saldır(); // Ateş edildi. MERMİ SAYISI: 9
               oyuncu1.saldır(); // Ateş edildi. MERMİ SAYISI: 8
               oyuncu1.silahi.sarjordegistir(5); // Şarjör Değiştirildi. MERMİ SAYISI: 13
               oyuncu1.saldır(); // Ateş edildi. MERMİ SAYISI:

           }
       }
       /*  class oyuncu
         {
             public string ad { get; set; }
             public string nickname { get; set; }
             public int yas { get; set; }
             public silah silahi { get; set; }
             public string NisanAl()
             {
                 return "";//nişan alma işlemeleri burada yapılacak
             }

             public void saldır()
             {
                 //saldırma işlemleri yapılacak
             }
         }
         /*  class silah
           {
               public int vurusgucu { get; set; }
               public double agirlik { get; set; }
               public int mesafe { get; set; }
           }
           class ateslisilahlar
           {
               public int maxmermi { get; set; }

               public int mermisayisi { get; set; }

               public void sarjordegistir(int adet)
               {
                   while (adet>0)
                   {
                       Console.ReadLine();
                       Console.WriteLine("MERMİ SAYISI: "+adet);
                       adet--;
                   }
                   if(adet==0)
                   {
                       Console.WriteLine("Şarjör Değiştir.");
                   }
               }*/
   /* class oyuncu
        {
            public string ad { get; set; }
            public string nickname { get; set; }
            public int yas { get; set; }
            public ateslisilahlar silahi { get; set; }

            public string NisanAl()
            {
                return ""; // nişan alma işlemeleri burada yapılacak
            }

            public void saldır()
            {
                if (silahi.mermisayisi > 0)
                {
                    silahi.mermisayisi--;
                    Console.WriteLine("MERMİ SAYISI: " + silahi.mermisayisi);
                    Console.WriteLine("Ateş edildi.");
                }
                else
                {
                    Console.WriteLine("Mermi yok!");
                }
            }
        }

        class silah
        {
            public int vurusgucu { get; set; }
            public double agirlik { get; set; }
            public int mesafe { get; set; }
        }

        class ateslisilahlar : silah
        {
            public int maxmermi { get; set; }
            public int mermisayisi { get; set; }

            public void sarjordegistir(int adet)
            {
                mermisayisi = Math.Min(mermisayisi + adet, maxmermi);
                Console.WriteLine("Şarjör Değiştirildi. MERMİ SAYISI: " + mermisayisi);
            }
        }*/
        #endregion
    }

    } 
}


