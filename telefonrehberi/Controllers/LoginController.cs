using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using telefonrehberi.Models;

namespace telefonrehberi.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        public IActionResult GirisYap1()
        {
            return View();
        }
        public async Task<IActionResult> GirisYap(Admin p)
        {
            var bilgiler = c.admin.FirstOrDefault(x=>x.Kullanici ==p.Kullanici && x.Sifre ==p.Sifre);
            if(bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.Kullanici)
                };
                var useridentity = new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Personel");

            }
            return View();
        }

    }
}
