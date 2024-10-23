using Business.Abstracts;
using DataAccessLayer.Abstracts;
using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Business.Concretes;

public class MessageManager : IMessageService
{
    IMessageDal _messageDal;

    public MessageManager(IMessageDal messageDal)
    {
        _messageDal = messageDal;
    }
    
    public void TAdd(Message entity)
    {
        _messageDal.Add(entity);
    }

    public List<Message> TGetList()
    {
        var values= _messageDal.GetList();
        return values;

    }

    public void TUpdate(Message entity)
    {
        _messageDal.Update(entity);
    }

    public void TDelete(Message entity)
    {
        _messageDal.Delete(entity);
    }

    public Message TGetById(int id)
    {
        var value = _messageDal.GetById(id);
        return value;
    }
}