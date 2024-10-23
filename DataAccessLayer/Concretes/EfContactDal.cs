using DataAccessLayer.Abstracts;
using DataAccessLayer.Repository;
using Entities;

namespace DataAccessLayer.Concretes;

public class EfContactDal : GenericRepository<Contact>, IContactDal
{
    
}