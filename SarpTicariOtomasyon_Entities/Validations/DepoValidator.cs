using FluentValidation;
using SarpTicariOtomasyon_Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarpTicariOtomasyon_Entities.Validations
{
   public class DepoValidator:AbstractValidator<Depo>
    {
        public DepoValidator()
        {
            RuleFor(p => p.DepoKodu).NotEmpty().WithMessage("Depo Kodu Alanı Boş Geçilemez.");
            RuleFor(p => p.DepoAdi).NotEmpty().WithMessage("Depo Adı Alanı Boş Geçilemez.");
        }
    }
}
