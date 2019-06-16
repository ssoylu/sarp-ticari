﻿using SarpTicariOtomasyon_Entities.Context;
using SarpTicariOtomasyon_Entities.Tables;
using SarpTicariOtomasyon_Entities.InterFaces;
using SarpTicariOtomasyon_Entities.RepoSitories;
using System.Data.Entity.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using SarpTicariOtomasyon_Entities.Validations;

namespace SarpTicariOtomasyon_Entities.Data_Access
{
    public class StokDAL:EntityRepositoryBase<SarpTicariOtomasyonContext,Stok,StokValidator>
    {
       

        public object GetAlljoin(SarpTicariOtomasyonContext context)
        {
            var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.StokKodu, c => c.StokKodu, (Stoklar, StokHareketleri) => new
            {
                Stoklar.Id,
                Stoklar.Durumu,
                Stoklar.StokKodu,
                Stoklar.StokAdi,
                Stoklar.Barkod,
                Stoklar.BarkodTuru,
                Stoklar.Birimi,
                Stoklar.StokGrubu,
                Stoklar.StokAltGrubu,
                Stoklar.Marka,
                Stoklar.Modeli,
                Stoklar.OzelKod1,
                Stoklar.OzelKod2,
                Stoklar.OzelKod3,
                Stoklar.OzelKod4,
                Stoklar.GarantiSuresi,
                Stoklar.UreticiKodu,
                Stoklar.AlisKdv,
                Stoklar.SatisKdv,
                Stoklar.AlisFiyati1,
                Stoklar.AlisFiyati2,
                Stoklar.AlisFiyati3,
                Stoklar.SatisFiyati1,
                Stoklar.SatisFiyati2,
                Stoklar.SatisFiyati3,
                Stoklar.MinStokMiktari,
                Stoklar.MaxStokMiktari,
                Stoklar.Aciklama,
                StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                StokCikis = StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                MevcutStok = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) -
                StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0

            }).ToList();
            return tablo;
           
        }
       
    }
}
