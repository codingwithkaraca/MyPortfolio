using Business.Concretes;
using DataAccessLayer.Concretes;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        
        // GET: PortfolioController
        public ActionResult Index()
        {
            var values = portfolioManager.TGetList();
            ViewBag.v1 = "Portfolio";
            ViewBag.v2 = "Index";
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.v1 = "Portfolio";
            ViewBag.v2 = "Add Portfolio";
            
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            portfolioManager.TAdd(portfolio);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            ViewBag.v1 = "Portfolio";
            ViewBag.v2 = "Edit Portfolio";

            var value = portfolioManager.TGetById(id);
            
            return View(value);
        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            
            portfolioManager.TUpdate(portfolio);
            return RedirectToAction("Index");
        }

        public IActionResult DeletePortfolio(int id)
        {
            var value = portfolioManager.TGetById(id);
            portfolioManager.TDelete(value);
            return RedirectToAction("Index");   
        }



    }
}
