using Microsoft.AspNetCore.Mvc;
using ProjetQarma.Models;
using System.Net;
using System.Net.Mail;
using System;
using System.Reflection.Metadata.Ecma335;

namespace ProjetQarma.Controllers
{
    public class EmailSetupController : Controller
    {
        public IActionResult Mail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Mail(ProjetQarma.Models.Gmail model)
        {
            MailMessage mm = new MailMessage("projetqarma@gmail.com", model.To);
            mm.Subject = model.Subject;
            mm.Body = model.Body;
            mm.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            NetworkCredential nc = new NetworkCredential("projetqarma@gmail.com", "vohyuconbhysobwe");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = nc;
            smtp.Send(mm);
            ViewBag.Message = "Le mail a bien été envoyé";

            return View("ConfirmationEnvoi");
        }

        
    }
}
