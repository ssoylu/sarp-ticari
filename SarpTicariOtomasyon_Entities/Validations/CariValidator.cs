using FluentValidation;
using SarpTicariOtomasyon_Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarpTicariOtomasyon_Entities.Validations
{
   public class CariValidator: AbstractValidator<Cari>
    {
        public CariValidator()
        {
            RuleFor(p => p.CariKodu).NotEmpty().WithMessage("Cari Kodu Alanı Boş Geçilemez.");
            RuleFor(p => p.CariAdi).NotEmpty().WithMessage("Cari Adı Alanı Boş Geçilemez.");
            RuleFor(p => p.YetkiliKisi).NotEmpty().WithMessage("Yetkili Kişi Alanı Boş Geçilemez.");
            RuleFor(p => p.FaturaUnvani).NotEmpty().WithMessage("Fatura Ünvanı Alanı Boş Geçilemez.");
            RuleFor(p => p.EMail).EmailAddress().WithMessage("Girdiğiniz e-mail Adresi Geçersiz.");
            RuleFor(p => p.IskontoOrani).GreaterThanOrEqualTo(0).WithMessage("İskonto Oranı Alanı 0'dan Küçük Olamaz.");
            RuleFor(p => p.RiskLimiti).GreaterThanOrEqualTo(0).WithMessage("Risk Limiti Alanı 0'dan Küçük Olamaz.");
        }
    }
}
