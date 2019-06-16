using FluentValidation;
using SarpTicariOtomasyon_Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarpTicariOtomasyon_Entities.Validations
{
    public  class OdemTuruValidator : AbstractValidator<OdemeTuru>
    {
        public OdemTuruValidator()
        {
            RuleFor(p => p.OdemeTuruKodu).NotEmpty().WithMessage("Ödme Türü Kodu Alanı Boş Geçilemez.");
            RuleFor(p => p.OdemeTuruAdi).NotEmpty().WithMessage("Ödme Türü Adı Alanı Boş Geçilemez.");
        }
    }
}
