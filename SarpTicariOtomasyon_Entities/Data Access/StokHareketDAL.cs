using SarpTicariOtomasyon_Entities.Context;
using SarpTicariOtomasyon_Entities.RepoSitories;
using SarpTicariOtomasyon_Entities.Tables;
using SarpTicariOtomasyon_Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarpTicariOtomasyon_Entities.Data_Access
{
    public class StokHareketDAL : EntityRepositoryBase<SarpTicariOtomasyonContext, StokHareket, StokHareketValidator>
    {
        public object GetGenelStok(SarpTicariOtomasyonContext contex, string stokKodu)
        {
            var result = (from c in contex.StokHareketleri.Where(c => c.StokKodu == stokKodu)
                          group c by new { c.Hareket } into g
                          select new
                          {
                              Bilgi = g.Key.Hareket,
                              KayitSayisi = g.Count(),
                              Toplam = g.Sum(c => c.Miktar)
                          }).ToList();
            return result;
        }

        public object GetDepoStok(SarpTicariOtomasyonContext contex, string stokKodu)
        {
            var result = contex.Depolar.GroupJoin(contex.StokHareketleri.Where(c => c.StokKodu == stokKodu), c => c.DepoKodu, c => c.DepoKodu, (depolar, stokhareketleri) => new
            {
                depolar.DepoKodu,
                depolar.DepoAdi,
                StokGiris = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                StokCikis = stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                MevcutStok = (stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0)
                    - (stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0)

            }).ToList();
            return result;
        }

        public object DepoStokListele(SarpTicariOtomasyonContext context,string depoKodu)
        {
            var tablo = context.Stoklar.GroupJoin(context.StokHareketleri.Where(c=>c.DepoKodu==depoKodu), c => c.StokKodu, c => c.StokKodu, (Stoklar, StokHareketleri) => new
            {
                              
                Stoklar.StokAdi,
                Stoklar.Barkod,               
                StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                StokCikis = StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                MevcutStok = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) -
                StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0

            }).ToList();
            return tablo;
        }

        public object DepoIstatistikListele(SarpTicariOtomasyonContext context, string depoKodu)
        {

            

            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                    Bilgi="Stok Giriş",
                    KayitSayisi=context.StokHareketleri.Where(c=>c.DepoKodu==depoKodu&& c.Hareket=="Stok Giriş").Count(),
                    Tutar=context.StokHareketleri.Where(c=>c.DepoKodu==depoKodu&& c.Hareket=="Stok Giriş").Sum(c=>c.Miktar)?? 0,
                   
                },
                 new GenelToplam
                {
                    Bilgi="Stok Çıkış",
                    KayitSayisi=context.StokHareketleri.Where(c=>c.DepoKodu==depoKodu&& c.Hareket=="Stok Çıkış").Count(),
                    Tutar=context.StokHareketleri.Where(c=>c.DepoKodu==depoKodu&& c.Hareket=="Stok Çıkış").Sum(c=>c.Miktar)?? 0,

                },
                 
            };
            return genelToplamlar;
        }
    }
}
