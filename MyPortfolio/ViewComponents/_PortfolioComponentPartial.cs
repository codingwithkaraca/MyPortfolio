using Business.Concretes;
using DataAccessLayer.Concretes;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents;

public class _PortfolioComponentPartial : ViewComponent
{
    PortfolioManager portfolioManager  = new PortfolioManager(new EfPortfolioDal());
    
    public IViewComponentResult Invoke()
    {
        var values = portfolioManager.TGetList(); 
        
        return View(values);
    }

}