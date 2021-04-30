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
    public class YazarManager : ManagerRepository<Yazar, IYazarDal, YazarValidator>, IYazarService, IFilterMethods<Yazar>
    {
        public YazarManager(IYazarDal x,YazarValidator y):base(x,y)
        {
        }

    }
}
