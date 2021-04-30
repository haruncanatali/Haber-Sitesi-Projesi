using HaberSitesi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HaberSitesi.Business.Concrete
{
    public interface IFilterMethods<TEntity> where TEntity:class,IEntity,new()
    {
        List<TEntity> List(Expression<Func<TEntity, bool>> filter = null);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
    }
}
