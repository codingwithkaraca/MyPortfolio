using Business.Concretes;
using DataAccessLayer.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents;

public class _ExperienceComponentPartial : ViewComponent
{
    ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
    public IViewComponentResult Invoke()
    {
        var values = experienceManager.TGetList();
        return View(values);
    }

}