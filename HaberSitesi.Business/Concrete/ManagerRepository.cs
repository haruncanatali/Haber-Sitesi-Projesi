using FluentValidation;
using HaberSitesi.Business.Abstract;
using HaberSitesi.Business.FluentValidation;
using HaberSitesi.DataAccess.Abstract;
using HaberSitesi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HaberSitesi.Business.Concrete
{
    public class ManagerRepository<TEntity,TDal, TValidator> : IServiceRepository<TEntity> where TEntity : class, IEntity, new() where TValidator : class, IValidator where TDal:IEntityRepository<TEntity>,IGetEntitiesOrEntity<TEntity>
    {
        TDal dal;
        TValidator validator;
        public ManagerRepository(TDal x,TValidator y)
        {
            dal = x;
            validator = y;
        }

        public void Add(TEntity entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            dal.Delete(entity);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return dal.Get(filter);
        }

        public List<TEntity> List(Expression<Func<TEntity, bool>> filter = null)
        {
            return dal.List(filter);
        }

        public void Update(TEntity entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Update(entity);
        }
    }
}
