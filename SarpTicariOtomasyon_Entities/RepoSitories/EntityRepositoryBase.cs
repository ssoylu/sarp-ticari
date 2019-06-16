using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using SarpTicariOtomasyon_Entities.InterFaces;
using System.Linq.Expressions;
using SarpTicariOtomasyon_Entities.Tools;
using FluentValidation;
using System.Text;
using System.Threading.Tasks;

namespace SarpTicariOtomasyon_Entities.RepoSitories
{
    public class EntityRepositoryBase<Tcontext, TEntity,TValidator> : IEntityReporsitory<Tcontext, TEntity>
         where Tcontext : DbContext, new()
        where TEntity : IEntity, new()
        where TValidator: IValidator, new()
    {
        public List<TEntity>GetAll(Tcontext contex, Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? contex.Set<TEntity>().ToList() : contex.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity GetByFilter(Tcontext context, Expression<Func<TEntity, bool>> filter)
        {
           return context.Set<TEntity>().SingleOrDefault(filter);
        }
        public bool AddOrUpdate(Tcontext context, TEntity entity)
        {

            TValidator validator = new TValidator();
            var validationResult = ValidatorTool.Validate(validator, entity);
            if (validationResult)
            {
                context.Set<TEntity>().AddOrUpdate(entity);
            }
            return validationResult;
            

           

        }

        public void Delete(Tcontext context, Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                context.Set<TEntity>().RemoveRange(context.Set<TEntity>().Where(filter));
            }
            catch (Exception)
            {

               
            }
           
        }

        public void Save(Tcontext context)
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception)
            {

                
            }
            
        }
    }

    public interface IEntityReporsitory<Tcontext, TEntity>
        where Tcontext : DbContext, new()
        where TEntity : IEntity, new()
    {
    }

}
