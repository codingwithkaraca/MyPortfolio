using Business.Concretes;
using DataAccessLayer.Concretes;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        // GET: ExperienceController
        public ActionResult Index()
        {
            ViewBag.v1 = "Experience";
            ViewBag.v2 = "Index";
            
            var values = experienceManager.TGetList();
            return View(values);
        }
        
        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Experience";
            ViewBag.v2 = "Add Experience";
            
            return View();
        }
        
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBag.v1 = "Experience";
            ViewBag.v2 = "Edit Experience";
            
            var values = experienceManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }
        
        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.TGetById(id);
            experienceManager.TDelete(values);
            return RedirectToAction("Index");

        }

    }
}
