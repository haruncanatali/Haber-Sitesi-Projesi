using HaberSitesi.Business.Abstract;
using HaberSitesi.Business.Concrete;
using HaberSitesi.Business.Ninject;
using HaberSitesi.Entities.Concrete;
using HaberSitesi.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace HaberSitesi.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IHaberService haberServis;
        public HomeController()
        {
            haberServis = InstanceFactory.GetInstance<IHaberService>();
        }

        public IActionResult Index()
        {
            return View(haberServis.List(null));
        }

    }
}
