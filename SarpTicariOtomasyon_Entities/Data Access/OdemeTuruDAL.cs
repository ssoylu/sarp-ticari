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
    public class OdemeTuruDAL: EntityRepositoryBase<SarpTicariOtomasyonContext, OdemeTuru,OdemTuruValidator>
    {
        public object OdemeTuruListele(SarpTicariOtomasyonContext context)
        {
            var result = context.OdemeTurleri.GroupJoin(context.KasaHareketleri, c => c.OdemeTuruKodu, c => c.OdemeTuruKodu,
                (odemeTuru, kasahareket) => new
                {
                    odemeTuru.Id,
                    odemeTuru.OdemeTuruKodu,
                    odemeTuru.OdemeTuruAdi,
                    odemeTuru.Aciklama,
                    
                    KasaGiris = (kasahareket.Where(c => c.OdemeTuruKodu == odemeTuru.OdemeTuruKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                    KasaCikis = (kasahareket.Where(c => c.OdemeTuruKodu == odemeTuru.OdemeTuruKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                    Bakiye = (kasahareket.Where(c => c.OdemeTuruKodu == odemeTuru.OdemeTuruKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0) -
                    (kasahareket.Where(c => c.OdemeTuruKodu == odemeTuru.OdemeTuruKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0)

                }).ToList();
            return result;
        }

        public object KasaToplamListele(SarpTicariOtomasyonContext context, string odemeTuruKodu)
        {
            var result = (from c in context.KasaHareketleri.Where(c => c.OdemeTuruKodu == odemeTuruKodu)
                          group c by new { c.KasaKodu,c.KasaAdi } into grp
                          select new
                          {
                              grp.Key.KasaKodu,
                              grp.Key.KasaAdi,
                              KasaGiris = (grp.Where(c => c.KasaKodu == grp.Key.KasaKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                              KasaCikis = (grp.Where(c => c.KasaKodu == grp.Key.KasaKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                              Bakiye = (grp.Where(c => c.KasaKodu == grp.Key.KasaKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0) -
                              (grp.Where(c => c.KasaKodu == grp.Key.KasaKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0)

                          }).ToList();
            return result;
        }

        public object GenelToplamListele(SarpTicariOtomasyonContext context, string odemeTuruKodu)
        {
            decimal KasaGiris = context.KasaHareketleri.Where(c => c.OdemeTuruKodu == odemeTuruKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0;

            int KasaGirisKayitSayisi = context.KasaHareketleri.Where(c => c.OdemeTuruKodu == odemeTuruKodu && c.Hareket == "Kasa Giriş").Count();

            decimal KasaCikis = context.KasaHareketleri.Where(c => c.OdemeTuruKodu == odemeTuruKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0;

            int KasaCikisKayitSayisi = context.KasaHareketleri.Where(c => c.OdemeTuruKodu == odemeTuruKodu && c.Hareket == "Kasa Çıkış").Count();

            List<GenelToplam> GenelToplamListele = new List<GenelToplam>()
            {
                new GenelToplam
                {
                    Bilgi="Kasa Giriş",
                    KayitSayisi=KasaGirisKayitSayisi,
                    Tutar=KasaGiris
                },
                 new GenelToplam
                {
                    Bilgi="Kasa Çıkış",
                    KayitSayisi=KasaCikisKayitSayisi,
                    Tutar=KasaCikis
                },
                  new GenelToplam
                {
                    Bilgi="Bakiye",
                    KayitSayisi=KasaGirisKayitSayisi+KasaCikisKayitSayisi,
                    Tutar=KasaCikis-KasaCikis
                }
            };
            return GenelToplamListele;
        }
    }
}
