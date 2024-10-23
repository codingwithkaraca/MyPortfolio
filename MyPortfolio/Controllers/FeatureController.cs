using Business.Concretes;
using DataAccessLayer.Concretes;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        // GET: FeatureController
        public ActionResult Index()
        {
            ViewBag.v1 = "Feature";
            ViewBag.v2 = "Index";
            var values = featureManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult EditFeature(int id)
        {
            ViewBag.v1 = "Feature";
            ViewBag.v2 = "Edit Feature";
            var value = featureManager.TGetById(id);
            return View(value);
        }
        
        [HttpPost]
        public IActionResult EditFeature(Feature feature)
        {
            featureManager.TUpdate(feature);
            return RedirectToAction("Index");   
        }
        
    }
}
