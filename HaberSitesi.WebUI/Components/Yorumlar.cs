using HaberSitesi.Business.Abstract;
using HaberSitesi.Business.Ninject;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberSitesi.WebUI.Components
{
    public class Yorumlar:ViewComponent
    {
        IYorumService yorumServis;
        public Yorumlar()
        {
            yorumServis = InstanceFactory.GetInstance<IYorumService>();
        }

        public IViewComponentResult Invoke()
        {
            return View("YorumlarView", yorumServis.List(null).OrderBy(c => c.YorumTarihi).Take(5).ToList());
        }
    }
}
