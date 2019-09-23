using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZORI_KIDS_KG.Models;

namespace ZORI_KIDS_KG.Controllers
{
    public class MailSenderController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }

        public ActionResult SendEmail(MailSenderViewModel model)
        {
            try
            {               
                var credentials = new NetworkCredential("kopaczgabi@gmail.com", "xqivbtnegiamawbr");
                
                var mail = new MailMessage()
                {
                    From = new MailAddress("noreply@zorikids.ro"),
                    Subject = model.Subiect,
                    Body = model.Name + ' ' + model.Email + ' ' + model.Telefon + ' ' + model.Message
                };

                mail.IsBodyHtml = true;
                mail.To.Add(new MailAddress("kopaczgabi@gmail.com"));
                
                var client = new SmtpClient()
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Credentials = credentials
                };

                client.Send(mail);               
            }
            catch (Exception e)
            {
               string asdfg = e.Message;
            }
            return RedirectToAction("Index", "Home");
        }
    }
}