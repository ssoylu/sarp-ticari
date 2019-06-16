using FluentValidation;
using SarpTicariOtomasyon_Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarpTicariOtomasyon_Entities.Validations
{
   public class TanimValidator : AbstractValidator<Tanim>
    {
        public TanimValidator()
        {
            RuleFor(p => p.Turu).NotEmpty().WithMessage("Tanım Türü Alanı Boş Geçilemez.");
            RuleFor(p => p.Tanimi).NotEmpty().WithMessage("Tanım Alanı Boş Geçilemez.");
        }
    }
}
