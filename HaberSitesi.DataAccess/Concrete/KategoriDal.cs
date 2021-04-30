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
    public class KategoriDal:EntityRepositoryBase<Kategori>,IKategoriDal
    {
        HaberSitesiDbContext context;
        public KategoriDal(HaberSitesiDbContext x):base(x)
        {
            context = x;
        }

        public Kategori Get(Expression<Func<Kategori, bool>> filter)
        {
            return context.Kategori.Include(c => c.Haberleri).FirstOrDefault(filter);
        }

        public List<Kategori> List(Expression<Func<Kategori, bool>> filter = null)
        {
            return filter == null ? context.Kategori.Include(c => c.Haberleri).ToList() : context.Kategori.Include(c => c.Haberleri).Where(filter).ToList();
        }

    }
}
