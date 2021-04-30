using HaberSitesi.DataAccess.Abstract;
using HaberSitesi.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.DataAccess.Concrete
{
    public class EntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        HaberSitesiDbContext context;
        public EntityRepositoryBase(HaberSitesiDbContext x)
        {
            context = x;
        }
        public void Add(TEntity entity)
        {        
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {         
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();   
        }

        public void Update(TEntity entity)
        {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
        }
    }
}
