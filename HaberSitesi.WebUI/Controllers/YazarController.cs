using HaberSitesi.Business.Abstract;
using HaberSitesi.Business.Ninject;
using HaberSitesi.Entities.Concrete;
using HaberSitesi.WebUI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberSitesi.WebUI.Controllers
{
    [Authorize]
    public class YazarController : Controller
    {
        IHesapHareketleriService hesapHareketServis;
        IYazarService yazarServis;
        IYaziService yaziServis;
        List<SelectListItem> yazarListesi;

        Yazar yazar;

        public YazarController()
        {
            hesapHareketServis = InstanceFactory.GetInstance<IHesapHareketleriService>();
            yazarServis = InstanceFactory.GetInstance<IYazarService>();
            yaziServis = InstanceFactory.GetInstance<IYaziService>();
        }

        public IActionResult Index(string x)
        {
            var _hesap = hesapHareketServis.Get(c => c.HesapId == int.Parse(x));
            yazar = yazarServis.Get(c => c.Id == _hesap.YazarId);
            return View(yazar);
        }

        [HttpGet]
        public IActionResult YaziEkle(int id)
        {
            yazarListesi = new List<SelectListItem>();
            foreach (var item in yazarServis.List(c => c.Id == id))
            {
                yazarListesi.Add(new SelectListItem
                {
                    Text = item.YazarAdi + " " + item.YazarSoyadi,
                    Value = item.Id.ToString()
                });
            }

            ViewBag._yazar = yazarListesi;

            return View(new YaziInputModel());
        }

        [HttpPost]
        public IActionResult YaziEkle(YaziInputModel model)
        {
            try
            {
                yaziServis.Add(new Yazi
                {
                    YazarId = int.Parse(model.YazarId),
                    YaziBasligi = model.YaziBasligi,
                    YaziIcerigi = model.YaziIcerigi,
                    YaziResimUrl = model.YaziResimUrl,
                    YaziTarihi = DateTime.Now
                });

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return Redirect("/Yazar/Index?x=" + yazarServis.Get(c => c.Id == int.Parse(model.YazarId)).HesapId.ToString());
        }

        [HttpGet]
        public IActionResult YaziGuncelle(int id)
        {
            var entity = yaziServis.Get(c => c.Id == id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult YaziGuncelle(Yazi model)
        {
            try
            {
                yaziServis.Update(model);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return Redirect("/Yazar/Index?x=" + yazarServis.Get(c => c.Id == model.YazarId).HesapId.ToString());
        }

        [HttpGet]
        public IActionResult YaziSil(int id)
        {
            string id_ = yaziServis.Get(c => c.Id == id).YazarId.ToString();
            id_ = hesapHareketServis.Get(c => c.YazarId == int.Parse(id_)).HesapId.ToString();
            try
            {
                yaziServis.Delete(yaziServis.Get(c => c.Id == id));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return Redirect("/Yazar/Index?x=" + id_);
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }

    }
}
