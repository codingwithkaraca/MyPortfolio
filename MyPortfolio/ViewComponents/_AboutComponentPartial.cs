using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents;

public class _AboutComponentPartial : ViewComponent
{
    MyPortfolioContext context = new MyPortfolioContext();
    
    public IViewComponentResult Invoke()
    {
        
        ViewBag.aboutTitle = context.Abouts.Select(x => x.Title).FirstOrDefault();
        ViewBag.aboutSubDescription = context.Abouts.Select(x => x.SubDescription).FirstOrDefault();
        ViewBag.aboutDescription = context.Abouts.Select(x => x.Details).FirstOrDefault();

        return View();
    }

}