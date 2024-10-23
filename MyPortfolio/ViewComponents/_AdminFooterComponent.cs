using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents;

public class _AdminFooterComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}