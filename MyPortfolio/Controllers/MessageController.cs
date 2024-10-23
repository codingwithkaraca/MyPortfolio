using System.Net;
using Business.Concretes;
using DataAccessLayer.Concretes;
using Entities.VM;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class MessageController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        
        public IActionResult Inbox()
        {
            ViewBag.v1 = "Message";
            ViewBag.v2 = "Inbox";
            var values = messageManager.TGetList();
            return View(values);
        }

        // alper yeni mesaj listesi yazımı
        [HttpGet]
        public IActionResult GetAllMessages()
        {
            
            if (messageManager == null)
            {
                return StatusCode(500, "MessageManager is null.");
            }

            var allMessages = messageManager.TGetList();
            if (allMessages == null)
            {
                return StatusCode(500, "No messages found.");
            }
            
            var messageList = new List<MessageVM>();

            foreach (var message in allMessages)
            {
                var messageListModel = new MessageVM()
                {
                    MessageId = message.MessageId,
                    NameSurname = message.NameSurname,
                    Subject = message.Subject,
                    Email = message.Email,
                    MessageDetail = message.MessageDetail,
                    SendDate = message.SendDate,
                    IsRead = message.IsRead,
                };
                messageList.Add(messageListModel);
            }

            return Ok(new { Code = HttpStatusCode.OK, messageList });
        }

        // Mesaj okunmadı 

        public IActionResult ChanceMessageToUnread(int id)
        {
            var message = messageManager.TGetById(id);
            message.IsRead = false;
            messageManager.TUpdate(message);
            return RedirectToAction("Inbox");
        }
        
        // Mesaj okundu
        public IActionResult ChanceMessageToRead(int id)
        {
            var message = messageManager.TGetById(id);
            message.IsRead = true;
            messageManager.TUpdate(message);
            return RedirectToAction("Inbox");
        }
        

        public IActionResult DeleteMessage(int id)
        {
            var value =messageManager.TGetById(id);
            messageManager.TDelete(value);
            return RedirectToAction("Inbox");
        }

        [HttpGet]
        public IActionResult MessageDetail(int id)
        {
            
            var value = messageManager.TGetById(id);

            if (value == null)
            {
                return NotFound();
            }
            
            return Json( new { 
                nameSurname = value.NameSurname,
                subject = value.Subject,
                email = value.Email,
                messageDetail = value.MessageDetail,
                sendDate = value.SendDate,
            });
            return View(value);
            
        }

    }
}
