using HaberSitesi.Business.Abstract;
using HaberSitesi.Business.Ninject;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberSitesi.WebUI.Controllers
{
    public class YorumController : Controller
    {
        IYorumService yorumService;
        public YorumController()
        {
            yorumService = InstanceFactory.GetInstance<IYorumService>();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YorumYap(int haberId,string ad,string soyad,string mesaj)
        {
            try
            {
                yorumService.Add(new Entities.Concrete.Yorum
                {
                    HaberId = haberId,
                    Ad = ad,
                    Soyad = soyad,
                    Mesaj = mesaj,
                    YorumTarihi = DateTime.Now
                });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return Redirect("/Haber/HaberGetir?id="+haberId.ToString());
        }
    }
}
