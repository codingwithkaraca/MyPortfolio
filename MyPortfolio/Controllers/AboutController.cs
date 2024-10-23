using Business.Concretes;
using DataAccessLayer.Concretes;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class AboutController : Controller
    {
        private AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            ViewBag.v1 = "About";
            ViewBag.v2 = "Index";
            var values = aboutManager.TGetList();
            return View(values);
        }
        
        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            ViewBag.v1 = "About";
            ViewBag.v2 = "Edit About";

            var values = aboutManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditAbout(About about)
        {
            if (string.IsNullOrEmpty(about.SubDescription))
            {
                about.SubDescription = null;
            }
            aboutManager.TUpdate(about);
            return RedirectToAction("Index");
        }
        
    }
}
