using HaberSitesi.Business.Abstract;
using HaberSitesi.Business.Ninject;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace HaberSitesi.WebUI.Components
{
    public class Haberlerim:ViewComponent
    {
        IHaberService haberServis;
        public Haberlerim()
        {
            haberServis = InstanceFactory.GetInstance<IHaberService>();
        }

        public IViewComponentResult Invoke(int id)
        {
            return View("HaberlerimView",haberServis.List(c => c.EditorId == id));
        }
    }
}
