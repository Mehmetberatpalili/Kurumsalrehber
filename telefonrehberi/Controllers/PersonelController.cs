using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using telefonrehberi.Models;

namespace telefonrehberi.Controllers
{
    public class PersonelController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.personels.Include(x=>x.Birim).ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniPersonel()
        {
            List<SelectListItem> degerler = (from x in c.birim.ToList()
                                             select new SelectListItem { 
                                                 Text = x.BirimAdi,
                                                 Value =x.BirimID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        [HttpPost]
        public IActionResult YeniPersonel(personel p )
        {
            var per = c.birim.Where(x=>x.BirimID==p.Birim.BirimID).FirstOrDefault();
            p.Birim = per;
            c.personels.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult PersonelSil(int id)
        {
            var per = c.personels.Find(id);
            c.personels.Remove(per);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult PersonelGetir(int id)
        {
            var personel = c.personels.Find(id);
            return View("PersonelGetir", personel);
        }
        public IActionResult PersonelGuncelle(personel p)
        {
            var per = c.personels.Find(p.perid);
            per.Tc = p.Tc;
            per.ad = p.ad;
            per.soyad = p.soyad;
            per.telefon = p.telefon;
            per.Adres = p.Adres;
            per.CalistigiBirim = p.CalistigiBirim;
            per.Gorev = p.Gorev;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
