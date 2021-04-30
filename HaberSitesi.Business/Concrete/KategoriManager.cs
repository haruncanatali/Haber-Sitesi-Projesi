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
    public class KategoriManager : ManagerRepository<Kategori, IKategoriDal, KategoriValidator>, IKategoriService
    {
        public KategoriManager(IKategoriDal x,KategoriValidator y):base(x,y)
        {
        }
       
    }
}
