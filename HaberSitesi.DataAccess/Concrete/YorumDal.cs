using HaberSitesi.DataAccess.Abstract;
using HaberSitesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HaberSitesi.DataAccess.Concrete
{
    public class YorumDal : EntityRepositoryBase<Yorum>, IYorumDal
    {
        HaberSitesiDbContext context;
        public YorumDal(HaberSitesiDbContext x):base(x)
        {
            context = x;
        }
        public Yorum Get(Expression<Func<Yorum, bool>> filter)
        {
            return context.Yorumlar.SingleOrDefault(filter);
        }

        public List<Yorum> List(Expression<Func<Yorum, bool>> filter = null)
        {
            return filter == null ? context.Yorumlar.ToList() : context.Yorumlar.Where(filter).ToList();
        }
    }
}
