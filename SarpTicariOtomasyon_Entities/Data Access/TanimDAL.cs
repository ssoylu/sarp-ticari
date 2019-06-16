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
    public class TanimDAL: EntityRepositoryBase<SarpTicariOtomasyonContext, Tanim,TanimValidator>
    {
    }
}
