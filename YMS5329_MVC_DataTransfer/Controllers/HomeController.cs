using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YMS5329_MVC_DataTransfer.Models;

namespace YMS5329_MVC_DataTransfer.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {

            List<Kategori> Kategoriler = new List<Kategori> {
                new Kategori { ID=1,Ad="İçecekler",Aciklama="Süt,Kola,Ayran vb"},
                new Kategori { ID=2,Ad="Deniz Mahsülleri",Aciklama="Hamsi,Somon Balığı,Levrek vb"},
                new Kategori { ID=3,Ad="Tatlılar",Aciklama="Sütlaç,Baklava,Dondurma vb"}
            };

            ViewBag.KategoriListesi = Kategoriler;
            ViewData["KategoriListesi"] = Kategoriler;
            TempData["KategoriListesi"] = Kategoriler;
            return View();
        }

        public ActionResult Category()
        {

            return View();

        }

    }
}