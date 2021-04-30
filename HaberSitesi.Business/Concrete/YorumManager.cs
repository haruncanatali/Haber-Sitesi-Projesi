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
    public class YorumManager : ManagerRepository<Yorum,IYorumDal,YorumValidator>,IYorumService
    {
        public YorumManager(IYorumDal dal,YorumValidator validator):base(dal,validator)
        {

        }
    }
}
