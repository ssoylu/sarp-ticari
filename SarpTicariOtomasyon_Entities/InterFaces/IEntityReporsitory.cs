using SarpTicariOtomasyon_Entities.Context;
using SarpTicariOtomasyon_Entities.Tables;
using System.Linq.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SarpTicariOtomasyon_Entities.InterFaces
{
    interface IEntityReporsitory<Tcontext,TEntity> 
        where Tcontext:DbContext,new()
        where TEntity:IEntity,new()

    {
        bool AddOrUpdate(Tcontext context, TEntity entity);
        void Delete(Tcontext context, Expression<Func<TEntity, bool>> filter);
        void Save(Tcontext context);
    }
}
