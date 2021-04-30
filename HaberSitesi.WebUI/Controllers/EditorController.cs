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
using X.PagedList;

namespace HaberSitesi.WebUI.Controllers
{
    [Authorize]
    public class EditorController : Controller
    {
        IHesapHareketleriService hesapHareketServis;
        IEditorService editorServis;
        IHaberService haberService;
        IKategoriService kategoriServis;
        Editor editor;
        List<SelectListItem> kategoriler;
        List<SelectListItem> editorler;

        public EditorController()
        {
            hesapHareketServis = InstanceFactory.GetInstance<IHesapHareketleriService>();
            editorServis = InstanceFactory.GetInstance<IEditorService>();
            haberService = InstanceFactory.GetInstance<IHaberService>();
            kategoriServis = InstanceFactory.GetInstance<IKategoriService>();

            kategoriler = new List<SelectListItem>();
            foreach (var item in kategoriServis.List(null))
            {
                kategoriler.Add(new SelectListItem
                {
                    Text = item.KategoriAdi,
                    Value = item.Id.ToString()
                });
            }
        }

        [HttpGet]
        public IActionResult Index(string x)
        {
            var _hesap = hesapHareketServis.Get(c => c.HesapId == int.Parse(x));
            editor = editorServis.Get(c => c.Id == _hesap.EditorId);
            return View(editor);
        }

        [HttpGet]
        public IActionResult HaberEkle(int id)
        {
            

            ViewBag.kategoriListesi = kategoriler;

            editorler = new List<SelectListItem>();
            foreach (var item in editorServis.List(c=>c.Id == id))
            {
                editorler.Add(new SelectListItem
                {
                    Text = item.EditorAdi+" "+item.EditorSoyadi,
                    Value = item.Id.ToString()
                });
            }

            ViewBag._editor = editorler;

            return View(new HaberInputModel());
        }

        [HttpPost]
        public IActionResult HaberEkle(HaberInputModel model)
        {
            try
            {
                haberService.Add(new Haber
                {
                    EditorId = int.Parse(model.EditorId),
                    KategoriId = int.Parse(model.KategoriId),
                    HaberAnaResimUrl = model.HaberAnaResimUrl,
                    HaberBasligi = model.HaberBasligi,
                    HaberIcerik = model.HaberIcerik,
                    HaberTarihi = DateTime.Now
                });
                
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return Redirect("/Editor/Index?x=" + editorServis.Get(c => c.Id == int.Parse(model.EditorId)).HesapId.ToString());
        }

        [HttpGet]
        public IActionResult HaberGuncelle(int id)
        {
            var entity = haberService.Get(c => c.Id == id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult HaberGuncelle(Haber model)
        {
            try
            {
                haberService.Update(model);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return Redirect("/Editor/Index?x=" + editorServis.Get(c => c.Id == model.EditorId).HesapId.ToString());
        }

        [HttpGet]
        public IActionResult HaberSil(int id)
        {
            string id_ = haberService.Get(c => c.Id == id).EditorId.ToString();
            id_ = hesapHareketServis.Get(c => c.EditorId == int.Parse(id_)).HesapId.ToString();
            try
            {
                haberService.Delete(haberService.Get(c=>c.Id == id));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return Redirect("/Editor/Index?x=" +id_ );
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
    }
}
