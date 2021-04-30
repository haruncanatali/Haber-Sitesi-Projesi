using HaberSitesi.Business.Abstract;
using HaberSitesi.DataAccess.Abstract;
using HaberSitesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HaberSitesi.Business.Concrete
{
    public class HesapHareketleriManager : IHesapHareketleriService
    {
        IHesapHareketleriDal dal;
        public HesapHareketleriManager(IHesapHareketleriDal _dal)
        {
            this.dal = _dal;
        }
        public HesapHareketleri Get(Expression<Func<HesapHareketleri, bool>> filter)
        {
            return dal.Get(filter);
        }

        public List<HesapHareketleri> List(Expression<Func<HesapHareketleri, bool>> filter = null)
        {
            return dal.List(filter);
        }
    }
}
