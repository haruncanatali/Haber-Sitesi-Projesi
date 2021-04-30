using HaberSitesi.Business.Abstract;
using HaberSitesi.Business.Ninject;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberSitesi.WebUI.Components
{
    public class GuncelYazilar:ViewComponent
    {
        IYaziService yaziServis;
        public GuncelYazilar()
        {
            yaziServis = InstanceFactory.GetInstance<IYaziService>();
        }

        public IViewComponentResult Invoke()
        {
            return View("GuncelYazilarView", yaziServis.List(null).OrderByDescending(c => c.YaziTarihi).Take(3).ToList());
        }
    }
}
