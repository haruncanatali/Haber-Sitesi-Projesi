using HaberSitesi.DataAccess.Abstract;
using HaberSitesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HaberSitesi.DataAccess.Concrete
{
    public class YazarDal : EntityRepositoryBase<Yazar>, IYazarDal
    {
        HaberSitesiDbContext context;
        public YazarDal(HaberSitesiDbContext x):base(x)
        {
            context = x;
        }

        public Yazar Get(Expression<Func<Yazar, bool>> filter)
        {
            return context.Yazar.Include(c => c.Yazilari).FirstOrDefault(filter);
        }

        public List<Yazar> List(Expression<Func<Yazar, bool>> filter = null)
        {
            return filter == null ? context.Yazar.Include(c => c.Yazilari).ToList() : context.Yazar.Include(c => c.Yazilari).Where(filter).ToList();
        }

    }
}
