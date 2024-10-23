using DataAccessLayer.Abstracts;
using DataAccessLayer.Repository;
using Entities;

namespace DataAccessLayer.Concretes;

public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
{
    
}