using Business.Abstracts;
using DataAccessLayer.Abstracts;
using Entities;

namespace Business.Concretes;

public class PortfolioManager : IPortfolioService
{
    IPortfolioDal _portfolioDal;

    public PortfolioManager(IPortfolioDal portfolioDal)
    {
        _portfolioDal = portfolioDal;
    }
    
    public void TAdd(Portfolio entity)
    {
        _portfolioDal.Add(entity);
        
    }

    public List<Portfolio> TGetList()
    {
        var values =_portfolioDal.GetList();
        return values;
    }

    public void TUpdate(Portfolio entity)
    {
        _portfolioDal.Update(entity);
    }

    public void TDelete(Portfolio entity)
    {
        _portfolioDal.Delete(entity);
    }

    public Portfolio TGetById(int id)
    {
        var value = _portfolioDal.GetById(id);
        return value;
    }
}