using HaberSitesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HaberSitesi.DataAccess.Abstract
{
    public interface IYazarDal:IEntityRepository<Yazar>,IGetEntitiesOrEntity<Yazar>
    {
    }
}
