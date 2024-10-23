using Business.Concretes;
using DataAccessLayer.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents;

public class _SkillComponentPartial : ViewComponent
{
    SkillManager skillManager = new SkillManager(new EfSkillDal());
    
    public IViewComponentResult Invoke()
    {
        var values = skillManager.TGetList();
        return View(values);
    }

}