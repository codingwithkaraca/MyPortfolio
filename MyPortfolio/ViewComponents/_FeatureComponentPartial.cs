using Business.Concretes;
using DataAccessLayer.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents;

public class _FeatureComponentPartial : ViewComponent
{
    private FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
    
    public IViewComponentResult Invoke()
    {
        var values = featureManager.TGetList();
        
        return View(values);
    }

}