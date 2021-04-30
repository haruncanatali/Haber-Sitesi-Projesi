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
    public class HaberManager : ManagerRepository<Haber, IHaberDal, HaberValidator>, IHaberService, IFilterMethods<Haber>
    {
        public HaberManager(IHaberDal x,HaberValidator y):base(x,y)
        {
        }

    }
}
