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
    public class YaziDal : EntityRepositoryBase<Yazi>, IYaziDal
    {
        HaberSitesiDbContext context;
        public YaziDal(HaberSitesiDbContext x):base(x)
        {
            context = x;
        }

        public Yazi Get(Expression<Func<Yazi, bool>> filter)
        {
            return context.Yazi.Include(c => c.Yazari).FirstOrDefault(filter);
        }

        public List<Yazi> List(Expression<Func<Yazi, bool>> filter = null)
        {
            return filter == null ? context.Yazi.Include(c => c.Yazari).ToList() : context.Yazi.Include(c => c.Yazari).Where(filter).ToList();
        }

    }
}
