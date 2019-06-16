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
   public class DepoDAL: EntityRepositoryBase<SarpTicariOtomasyonContext, Depo,DepoValidator>
    {
        public object DepoBazindaStokListele(SarpTicariOtomasyonContext context,string stokKodu)
        {
            var result = context.Depolar.GroupJoin(context.StokHareketleri.Where(c => c.StokKodu == stokKodu), c => c.DepoKodu, c => c.DepoKodu, (depolar, stokhareketleri) => new
            {
                depolar.Id,
                depolar.DepoKodu,
                depolar.DepoAdi,
                depolar.YetkiliKodu,
                depolar.YetkiliAdi,
                depolar.Telefon,
                depolar.Il,
                depolar.Ilce,
                depolar.Semt,
                depolar.Adres,
                depolar.Aciklama,
                StokGiris = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                StokCikis = stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                MevcutStok = (stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0)
                    - (stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0)

            }).ToList();
            return result;
        }
    }
}
