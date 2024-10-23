using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents;

public class _AdminScriptComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}