using HaberSitesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.DataAccess.Abstract
{
    public interface IYorumDal:IEntityRepository<Yorum>,IGetEntitiesOrEntity<Yorum>
    {

    }
}
