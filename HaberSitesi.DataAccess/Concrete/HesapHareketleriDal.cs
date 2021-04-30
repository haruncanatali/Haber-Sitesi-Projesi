using HaberSitesi.DataAccess.Abstract;
using HaberSitesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HaberSitesi.DataAccess.Concrete
{
    public class HesapHareketleriDal : IHesapHareketleriDal
    {
        HaberSitesiDbContext context;
        public HesapHareketleriDal(HaberSitesiDbContext x)
        {
            context = x;
        }
        public HesapHareketleri Get(Expression<Func<HesapHareketleri, bool>> filter)
        {
            return context.HesapHareketleri.SingleOrDefault(filter);
        }

        public List<HesapHareketleri> List(Expression<Func<HesapHareketleri, bool>> filter = null)
        {
            return filter == null ? context.HesapHareketleri.ToList() : context.HesapHareketleri.Where(filter).ToList();
        }
    }
}
