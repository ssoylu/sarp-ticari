﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SarpTicariOtomasyon_Entities.Context;
using SarpTicariOtomasyon_Entities.InterFaces;
using SarpTicariOtomasyon_Entities.RepoSitories;
using SarpTicariOtomasyon_Entities.Tables;
using SarpTicariOtomasyon_Entities.Validations;

namespace SarpTicariOtomasyon_Entities.Data_Access
{
    
    public class CariDAL : EntityRepositoryBase<SarpTicariOtomasyonContext, Cari, CariValidator>
    {

        public object GetCariler(SarpTicariOtomasyonContext context)
        {
            var result = context.Cariler.GroupJoin(context.Fisler, c => c.CariKodu, c => c.CariKodu, (cariler, fisler) => new
            {
                cariler.Id,
                cariler.Durumu,
                cariler.CariKodu,
                cariler.CariAdi,
                cariler.CariTuru,
                cariler.YetkiliKisi,
                cariler.FaturaUnvani,
                cariler.CepTelefonu,
                cariler.Telefon,
                cariler.Fax,
                cariler.EMail,
                cariler.Web,
                cariler.Il,
                cariler.Ilce,
                cariler.Semt,
                cariler.Adres,
                cariler.CariGrubu,
                cariler.CariAltGrubu,
                cariler.OzelKod1,
                cariler.OzelKod2,
                cariler.OzelKod3,
                cariler.OzelKod4,
                cariler.VergiDairesi,
                cariler.VergiNo,
                cariler.IskontoOrani,
                cariler.RiskLimiti,
                cariler.AlisOzelFiyati,
                cariler.SatisOzelFiyati,
                cariler.Acıklama,

                AlisToplam = fisler.Where(c => c.FisTuru == "Alış Faturası").Sum(c => c.ToplamTutar) ?? 0,
                SatisToplam = fisler.Where(c => c.FisTuru == "Satış Faturası").Sum(c => c.ToplamTutar) ?? 0
            }).GroupJoin(context.KasaHareketleri, c => c.CariKodu, c => c.CariKodu, (cariler, kasahareket) => new
            {
                cariler.Id,
                cariler.Durumu,
                cariler.CariKodu,
                cariler.CariAdi,
                cariler.CariTuru,
                cariler.YetkiliKisi,
                cariler.FaturaUnvani,
                cariler.CepTelefonu,
                cariler.Telefon,
                cariler.Fax,
                cariler.EMail,
                cariler.Web,
                cariler.Il,
                cariler.Ilce,
                cariler.Semt,
                cariler.Adres,
                cariler.CariGrubu,
                cariler.CariAltGrubu,
                cariler.OzelKod1,
                cariler.OzelKod2,
                cariler.OzelKod3,
                cariler.OzelKod4,
                cariler.VergiDairesi,
                cariler.VergiNo,
                cariler.IskontoOrani,
                cariler.RiskLimiti,
                cariler.AlisOzelFiyati,
                cariler.SatisOzelFiyati,
                cariler.Acıklama,
                Alacak = cariler.AlisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                Borc = cariler.SatisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                Bakiye = (cariler.AlisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0))
                - (cariler.SatisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0))

            }).ToList();
            return result;
        }

        public object CariFisAyrinti(SarpTicariOtomasyonContext context, string cariKodu)
        {
            var result = context.Fisler.Where(c => c.CariKodu == cariKodu).GroupJoin(
                context.KasaHareketleri.Where(c => c.CariKodu == cariKodu), c => c.CariKodu, c => c.CariKodu,
                (fisler, Kasahareket) => new
                {
                    fisler.Id,
                    fisler.FisKodu,
                    fisler.FisTuru,
                    fisler.PlasiyerKodu,
                    fisler.PlasiyerAdi,
                    fisler.BelgeNo,
                    fisler.Tarih,
                    fisler.IskontoOrani,
                    fisler.IskontoTutar,
                    fisler.Aciklama,
                    fisler.ToplamTutar,
                    Odenen = context.KasaHareketleri.Where(c=>c.FisKodu == fisler.FisKodu).Sum(c => c.Tutar) ?? 0,
                    KalanOdeme = fisler.ToplamTutar - context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).Sum(c => c.Tutar) ?? 0,
                }).ToList();
            return result;

        }

        public object CariFisGenelToplam(SarpTicariOtomasyonContext context, string cariKodu)
        {
            var result = (from c in context.Fisler.Where(c => c.CariKodu == cariKodu)
                          group c by new { c.FisTuru} into grp
                          select new
                          {
                              Bilgi = grp.Key.FisTuru,
                              KayitSayisi = grp.Count(),
                              Tutar = grp.Sum(c => c.ToplamTutar)
                          }).ToList();
            return result;
        }

        public object CariGenelToplam(SarpTicariOtomasyonContext context, string cariKodu)
        {

            decimal alacak = (context.Fisler.Where(c => c.CariKodu == cariKodu && c.FisTuru == "Alış Faturası")
                .Sum(c => c.ToplamTutar) ?? 0) +
               (context.KasaHareketleri.Where(c => c.CariKodu == cariKodu && c.Hareket == "Kasa Giriş")
               .Sum(c => c.Tutar) ?? 0);

            decimal borc = (context.Fisler.Where(c => c.CariKodu == cariKodu && c.FisTuru == " Satış Faturası")
               .Sum(c => c.ToplamTutar) ?? 0) +
              (context.KasaHareketleri.Where(c => c.CariKodu == cariKodu && c.Hareket == "Kasa Çıkış")
              .Sum(c => c.Tutar) ?? 0);

            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                    Bilgi="Alacak",
                    Tutar=alacak
                },
                 new GenelToplam
                {
                    Bilgi="Borç",
                    Tutar=borc
                },
                  new GenelToplam
                {
                    Bilgi="Bakiye",
                    Tutar=alacak-borc
                }
            };
            return genelToplamlar;
        }

        public CariBakiye CariBakiyesi(SarpTicariOtomasyonContext context,string cariKodu)
        {
            decimal alacak = (context.Fisler.Where(c => c.CariKodu == cariKodu && c.FisTuru == "Alış Faturası")
                .Sum(c => c.ToplamTutar) ?? 0) +
               (context.KasaHareketleri.Where(c => c.CariKodu == cariKodu && c.Hareket == "Kasa Giriş")
               .Sum(c => c.Tutar) ?? 0);

            decimal borc = (context.Fisler.Where(c => c.CariKodu == cariKodu && c.FisTuru == " Satış Faturası")
               .Sum(c => c.ToplamTutar) ?? 0) +
              (context.KasaHareketleri.Where(c => c.CariKodu == cariKodu && c.Hareket == "Kasa Çıkış")
              .Sum(c => c.Tutar) ?? 0);
            CariBakiye entity = new CariBakiye
            {
                CariKodu = cariKodu,
                RiskLimiti =Convert.ToDecimal(context.Cariler.Where(c => c.CariKodu == cariKodu).SingleOrDefault().RiskLimiti),
                Alacak=alacak,
                Borc=borc,
                Bakiye=alacak-borc,
            };
            return entity;          

        }
    }

}
