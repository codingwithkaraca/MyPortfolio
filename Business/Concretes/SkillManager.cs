using Business.Abstracts;
using DataAccessLayer.Abstracts;
using Entities;

namespace Business.Concretes;

public class SkillManager: ISkillService
{
    ISkillDal _skillDal;

    public SkillManager(ISkillDal skillDal)
    {
        _skillDal = skillDal;
    }
    
    public void TAdd(Skill entity)
    {
        throw new NotImplementedException();
    }

    public List<Skill> TGetList()
    {
        var values= _skillDal.GetList();
        return values;
    }

    public void TUpdate(Skill entity)
    {
        throw new NotImplementedException();
    }

    public void TDelete(Skill entity)
    {
        throw new NotImplementedException();
    }

    public Skill TGetById(int id)
    {
        throw new NotImplementedException();
    }
}