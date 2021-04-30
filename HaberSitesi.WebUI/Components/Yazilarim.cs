using HaberSitesi.Business.Abstract;
using HaberSitesi.Business.Ninject;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberSitesi.WebUI.Components
{
    public class Yazilarim:ViewComponent
    {
        IYaziService yaziServis;
        public Yazilarim()
        {
            yaziServis = InstanceFactory.GetInstance<IYaziService>();
        }

        public IViewComponentResult Invoke(int id)
        {
            return View("YazilarimView",yaziServis.List(c => c.YazarId == id));
        }
    }
}
