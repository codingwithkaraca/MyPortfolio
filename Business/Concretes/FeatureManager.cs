using Business.Abstracts;
using DataAccessLayer.Abstracts;
using Entities;

namespace Business.Concretes;

public class FeatureManager : IFeatureService
{
    
    IFeatureDal _featureDal;

    public FeatureManager(IFeatureDal featureDal)
    {
        _featureDal = featureDal;
    }
    
    public void TAdd(Feature entity)
    {
        _featureDal.Add(entity);
        
    }

    public List<Feature> TGetList()
    {
        var values = _featureDal.GetList();

        return values;
    }

    public void TUpdate(Feature entity)
    {
        _featureDal.Update(entity);
    }

    public void TDelete(Feature entity)
    {
        _featureDal.Delete(entity);
    }

    public Feature TGetById(int id)
    {
        var value = _featureDal.GetById(id);
        
        return value;
    }
}