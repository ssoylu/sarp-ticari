using FluentValidation;
using SarpTicariOtomasyon_Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SarpTicariOtomasyon_Entities.Validations
{
   public class KasaValidator : AbstractValidator<Kasa>
    {
        public KasaValidator()
        {
            RuleFor(p => p.KasaKodu).NotEmpty().WithMessage("Kasa Kodu Alanı Boş Geçilemez.");
            RuleFor(p => p.KasaAdi).NotEmpty().WithMessage("Kasa Adı Alanı Boş Geçilemez.");
        }
    }
}
