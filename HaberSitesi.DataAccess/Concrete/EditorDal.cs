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
    public class EditorDal : EntityRepositoryBase<Editor>, IEditorDal
    {
        HaberSitesiDbContext context;
        public EditorDal(HaberSitesiDbContext x):base(x)
        {
            context = x;
        }

        public Editor Get(Expression<Func<Editor, bool>> filter)
        {
            return context.Editor.Include(c => c.Haberleri).FirstOrDefault(filter);
        }


        public List<Editor> List(Expression<Func<Editor, bool>> filter = null)
        {
            var entity = filter == null ? context.Editor.Include(c => c.Haberleri).ToList() : context.Editor.Include(c => c.Haberleri).Where(filter).ToList();
            return entity;
        }
    }
}