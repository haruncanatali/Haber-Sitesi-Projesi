using HaberSitesi.Business.Abstract;
using HaberSitesi.Business.Ninject;
using HaberSitesi.Entities.Concrete;
using HaberSitesi.WebUI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HaberSitesi.WebUI.Controllers
{
    public class Login : Controller
    {
        IHesapService hesapServis;
        public Login()
        {
            hesapServis = InstanceFactory.GetInstance<IHesapService>();
        }

        public IActionResult Index()
        {
            return View(new LoginModel());
        }

        [HttpPost]
        public async Task<IActionResult> GirisYap(LoginModel entity)
        {
            if (String.IsNullOrEmpty(entity.Username))
            {
                ModelState.AddModelError(nameof(entity.Username), "Kullanıcı adı alanı zorunludur.");
            }
            else if (String.IsNullOrEmpty(entity.Password))
            {
                ModelState.AddModelError(nameof(entity.Password), "Şifre zorunludur.");
            }
            else if((entity.IsAuthor==false && entity.IsEditor == false) || (entity.IsAuthor == true && entity.IsEditor == true))
            {
                ModelState.AddModelError(nameof(entity.IsAuthor), "Giriş yöntemi zorunludur.");
            }

            var entity_ = hesapServis.Get(c => c.Username == entity.Username && c.Password == entity.Password);
            
            if(entity_ == null)
            {
                ModelState.AddModelError(nameof(entity.Username), "Kullanıcı Adı veya Şifresi Hatalı.");
            }

            if (ModelState.IsValid)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,entity.Username)
                };
                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                if (entity.IsEditor == true)
                {
                    return Redirect("/Editor/Index?x="+entity_.Id.ToString());
                }
                else if (entity.IsAuthor == true)
                {
                    return Redirect("/Yazar/Index?x="+ entity_.Id.ToString());
                }         
                return View("Index", entity);               
            }
            else
            {
                return View("Index", entity_);
            }
        }
    }
}
