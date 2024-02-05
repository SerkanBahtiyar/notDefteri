using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using notDefteri.Models.Entity;
namespace notDefteri.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        notDefteriEntities sb = new notDefteriEntities();
        public ActionResult Index()
        {
            var degerler = sb.notTablosu.ToList();
            return View(degerler);
        }
        [HttpGet]
        public PartialViewResult ilet()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult ilet(notTablosu t)
        {
            sb.notTablosu.Add(t);
            sb.SaveChanges();
            return PartialView();
        }
    }
}