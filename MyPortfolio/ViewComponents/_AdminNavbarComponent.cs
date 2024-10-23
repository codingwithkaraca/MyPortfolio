using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents;

public class _AdminNavbarComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }

}