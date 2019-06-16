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
    public class PersonelDAL : EntityRepositoryBase<SarpTicariOtomasyonContext, Personel, PersonelValidator>
    {
        public object PersonelListele(SarpTicariOtomasyonContext context)
        {
            var result = context.Personeller.GroupJoin(context.Fisler, c => c.PersonelKodu, c => c.PlasiyerKodu,
                (personel, fis) => new
                {
                    personel.ıd,
                    personel.Calisiyor,
                    personel.PersonelKodu,
                    personel.PersonelAdi,
                    personel.Unvani,
                    personel.TcKimlikNo,
                    personel.IseGirisTarihi,
                    personel.IstenCikisTarihi,
                    personel.VergiDairesi,
                    personel.VergiNo,
                    personel.CepTelefonu,
                    personel.Telefon,
                    personel.Fax,
                    personel.Il,
                    personel.Ilce,
                    personel.Semt,
                    personel.Adres,
                    personel.Email,
                    personel.Web,
                    personel.PirimOrani,
                    personel.AylikMaasi,
                    personel.Aciklama,
                    ToplamSatis = fis.Where(c => c.FisTuru == "Perakende Satış Faturası").Sum(c => c.ToplamTutar) ?? 0,
                    PrimTutari =
                        (fis.Where(c => c.FisTuru == "Perakende Satış Faturası").Sum(c => c.ToplamTutar) ?? 0) / 100 *
                        personel.PirimOrani
                }).ToList();
            return result;

        }
    }
}
