using HaberSitesi.Business.Abstract;
using HaberSitesi.DataAccess.Abstract;
using HaberSitesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HaberSitesi.Business.Concrete
{
    public class HesapManager : IHesapService
    {
        IHesapDal dal;
        public HesapManager(IHesapDal _dal)
        {
            dal = _dal;
        }
        public Hesaplar Get(Expression<Func<Hesaplar, bool>> filter)
        {
            return dal.Get(filter);
        }

        public List<Hesaplar> List(Expression<Func<Hesaplar, bool>> filter = null)
        {
            return dal.List(filter);
        }
    }
}
