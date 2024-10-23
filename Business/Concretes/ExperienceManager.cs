using Business.Abstracts;
using DataAccessLayer.Abstracts;
using Entities;

namespace Business.Concretes;

public class ExperienceManager : IExperienceService
{
    IExperienceDal _experienceDal;

    public ExperienceManager(IExperienceDal experienceDal)
    {
        _experienceDal = experienceDal;
    }
    
    public void TAdd(Experience entity)
    {
        _experienceDal.Add(entity);
    }

    public List<Experience> TGetList()
    {
        var values = _experienceDal.GetList();
        return values;
    }

    public void TUpdate(Experience entity)
    {
        _experienceDal.Update(entity);
    }

    public void TDelete(Experience entity)
    {
       _experienceDal.Delete(entity);
    }

    public Experience TGetById(int id)
    {
        var experience = _experienceDal.GetById(id);
        return experience;
    }
}