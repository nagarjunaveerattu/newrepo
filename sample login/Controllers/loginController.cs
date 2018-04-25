
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sample_login.Models;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Metadata.Edm;

namespace sample_login.Controllers
{
    public class loginController : Controller
    {
        [HttpGet]
        public ActionResult createuser(int id = 0)
        {
            login obj = new login();
            return View(obj);
        }
        [HttpPost]
        public ActionResult createuser(login obj)
        {
            using (maktronEntities mn=new maktronEntities())
            {
                mn.logins.Add(obj);
                mn.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.sucessfullmessage = "welcome to login.";
            return View("createuser", new login());


        }
    }
}
    
