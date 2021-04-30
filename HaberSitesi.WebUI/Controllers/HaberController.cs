using HaberSitesi.Business.Abstract;
using HaberSitesi.Business.Ninject;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberSitesi.WebUI.Controllers
{
    public class HaberController : Controller
    {
        IHaberService haberServis;
        public HaberController()
        {
            haberServis = InstanceFactory.GetInstance<IHaberService>();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult HaberGetir(int id)
        {
            return View(haberServis.Get(c => c.Id == id));
        }

        [HttpGet]
        public IActionResult HaberFiltrele(string kategoriAdi)
        {
            var listOfCategory = haberServis.List(c => c.Kategorisi.KategoriAdi == kategoriAdi);
            return View(listOfCategory);
        }
    }
}
