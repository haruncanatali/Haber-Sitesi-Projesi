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
    public class EditorManager:ManagerRepository<Editor,IEditorDal,EditorValidator>,IEditorService,IFilterMethods<Editor>
    {
        public EditorManager(IEditorDal x,EditorValidator y):base(x,y)
        {
        }
    }
}
