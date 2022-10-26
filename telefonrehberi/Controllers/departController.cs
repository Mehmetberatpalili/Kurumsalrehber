using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using telefonrehberi.Models;

namespace telefonrehberi.Controllers
{
    public class departController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.departmanlars.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniDepartman()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniDepartman(departmanlar d)
        {
            c.departmanlars.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DepartmanSil(int id)
        {
            var dep = c.departmanlars.Find(id);
            c.departmanlars.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DepartmanGetir(int id)
        {
            var depart = c.departmanlars.Find(id);
            return View("DepartmanGetir",depart);
        }
        public IActionResult DepartmanGuncelle(departmanlar d)
        {
            var dep = c.departmanlars.Find(d.id);
            dep.departmanad = d.departmanad;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
    
}
