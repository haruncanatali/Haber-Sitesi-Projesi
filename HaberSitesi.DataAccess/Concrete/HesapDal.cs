using HaberSitesi.DataAccess.Abstract;
using HaberSitesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HaberSitesi.DataAccess.Concrete
{
    public class HesapDal : IHesapDal
    {
        HaberSitesiDbContext context;
        public HesapDal(HaberSitesiDbContext x)
        {
            context = x;
        }
        public Hesaplar Get(Expression<Func<Hesaplar, bool>> filter)
        {
            return context.Hesaplar.FirstOrDefault(filter);
        }

        public List<Hesaplar> List(Expression<Func<Hesaplar, bool>> filter = null)
        {
            return filter != null ? context.Hesaplar.Where(filter).ToList() : context.Hesaplar.ToList();
        }
    }
}
