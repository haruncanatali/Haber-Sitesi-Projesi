using HaberSitesi.Business.Abstract;
using HaberSitesi.Business.Ninject;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberSitesi.WebUI.Controllers
{
    public class YaziController : Controller
    {
        IYaziService yaziServis;
        public YaziController()
        {
            yaziServis = InstanceFactory.GetInstance<IYaziService>();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult YaziGetir(int id)
        {
            return View(yaziServis.Get(c => c.Id == id));
        }

        [HttpGet]
        public IActionResult YazilariListele()
        {
            return View(yaziServis.List(null));
        }
    }
}
