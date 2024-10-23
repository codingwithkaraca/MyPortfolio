using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents;

public class _AdminHeadComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }

}