using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NasaProdavnica.Models;

namespace NasaProdavnica.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Nasa Prodavnica";

            return View();
        }
        [HttpGet]
        public ActionResult UnosLaptop()
        {
            Proizvodjac[] proizvodjaci = new Proizvodjac[]
            {
                new Proizvodjac("Acer","www.google.com"),
                new Proizvodjac("hp","www.google.com"),
                new Proizvodjac("Lenovo","www.google.com")
            };
            List<string> naziv = new List<string>();
            foreach (Proizvodjac p in proizvodjaci)
            {
                naziv.Add(p.naziv);

            }
            ViewBag.naziv = naziv;

            return View();
        }
        [HttpPost]
        public ActionResult UnosLaptop(MainModel proizvod)
        {
           
            return View("PregledLaptop",proizvod);
        }

        [HttpGet]
        public ActionResult UnosTastatura()
        {
            Proizvodjac[] proizvodjaci = new Proizvodjac[]
           {
                new Proizvodjac("Razor","www.google.com"),
                new Proizvodjac("RedDragon","www.google.com"),
                new Proizvodjac("Logitech","www.google.com")
           };
            List<string> naziv = new List<string>();
            foreach (Proizvodjac p in proizvodjaci)
            {
                naziv.Add(p.naziv);

            }
            ViewBag.naziv = naziv;

            return View();
        }
        [HttpPost]
        public ActionResult UnosTastatura(MainModel proizvod)
        {
            return View("PregledTastatura", proizvod);
        }



    }
}