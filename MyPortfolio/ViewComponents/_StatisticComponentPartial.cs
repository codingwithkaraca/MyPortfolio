using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents;

public class _StatisticComponentPartial : ViewComponent
{
    MyPortfolioContext _context= new MyPortfolioContext();
    public IViewComponentResult Invoke()
    {
        ViewBag.v1 = _context.Skills.Count(); 
        // deneyim sayısı
        ViewBag.v2 = _context.Experiences.Count();
        // okunan
        ViewBag.v3 = _context.Messages.Where(x => x.IsRead == true);
        // Okunmayan mesajlar
        ViewBag.v4 = _context.Messages.Where(x => x.IsRead == false);
        // proje sayısı
        ViewBag.v5 = _context.Portfolios.Count();
        //toplam mesaj sayısı
        ViewBag.v6 = _context.Messages.Count();
        
        return View();
    }

}