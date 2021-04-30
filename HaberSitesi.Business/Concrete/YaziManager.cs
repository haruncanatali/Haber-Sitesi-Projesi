using HaberSitesi.Business.Abstract;
using HaberSitesi.Business.FluentValidation;
using HaberSitesi.DataAccess.Abstract;
using HaberSitesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HaberSitesi.Business.Concrete
{
    public class YaziManager : ManagerRepository<Yazi, IYaziDal, YaziValidator>, IYaziService, IFilterMethods<Yazi>
    {
        public YaziManager(IYaziDal x,YaziValidator y):base(x,y)
        {
        }

    }
}
