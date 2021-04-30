using HaberSitesi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.DataAccess.Abstract
{
    public interface IEntityRepository<TEntity> where TEntity: class, IEntity,new()
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
