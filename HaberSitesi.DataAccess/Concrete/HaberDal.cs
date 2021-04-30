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
    public class HaberDal:EntityRepositoryBase<Haber>,IHaberDal
    {
        HaberSitesiDbContext context;
        public HaberDal(HaberSitesiDbContext x):base(x)
        {
            context = x;
        }

        public Haber Get(Expression<Func<Haber, bool>> filter)
        {
            return context.Haber.Include(c => c.Editoru).Include(c => c.Kategorisi).Include(c=>c.Yorumlar).FirstOrDefault(filter);
        }

        public List<Haber> List(Expression<Func<Haber, bool>> filter = null)
        {
            return filter == null ? context.Haber.Include(c => c.Editoru).Include(c => c.Yorumlar).Include(c => c.Kategorisi).ToList() : context.Haber.Include(c => c.Editoru).Include(c => c.Kategorisi).Include(c => c.Yorumlar).Where(filter).ToList();
        }

    }
}
