//using EurosSite.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Mail;
//using System.Web;
//using System.Web.Mvc;
//using Umbraco.Web.Mvc;

//namespace EurosSite.Controllers
//{
//    public class RegisterFormSurfaceController : SurfaceController
//    {
//        // GET: RegisterFormSurface
//        public ActionResult Index()
//        {
//            return PartialView("RegisterForm", new RegisterFormViewModel());
//        }

//        [HttpPost]
//        public ActionResult HandleFormSumbit(RegisterFormViewModel model)
//        {
//            //send email
//            MailMessage message = new MailMessage();
//            message.To.Add("ben.martin@madetoengage.com");
//            message.Subject = "New event entry registered";
//            message.From = new System.Net.Mail.MailAddress(model.EmailAddress);
//            message.Body = model.FirstName, m
//        }
//    }
//}