using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using telefonrehberi.Models;

namespace telefonrehberi.Controllers
{
    public class BirimController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.birim.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniBirim()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniBirim(Birim b)
        {
            c.birim.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult BirimSil(int id)
        {
            var dep = c.birim.Find(id);
            c.birim.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult BirimGetir(int id)
        {
            var depart = c.birim.Find(id);
            return View("BirimGetir", depart);
        }
        public IActionResult BirimGuncelle(Birim b)
        {
            var dep = c.birim.Find(b.BirimID);
            dep.BirimAdi = b.BirimAdi;
            dep.BirimYoneticisi = b.BirimYoneticisi;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult BirimDetay(int id)
        {
            var degerler = c.personels.Where(x=>x.BirimID==id ).ToList();
            var brmad = c.birim.Where(x => x.BirimID == id).Select(y=>y.BirimAdi).FirstOrDefault();
            ViewBag.brm = brmad;
            return View(degerler);
        }
    }
}
