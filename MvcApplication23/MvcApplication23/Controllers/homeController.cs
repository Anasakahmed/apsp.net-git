using MvcApplication23.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication23.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult contact()
        {
            return View();
        }

        public ActionResult convocations()
        {
            return View();
        }
        //

        public ActionResult orientation()
        {
            return View();
        }

        public ActionResult staffgalllery()
        {
            return View();
        }
     
        [HttpGet]
        public ActionResult admission()
        {
            return View();
        }


       [HttpPost]
       public ActionResult admission(students stu)
       {
           if (ModelState.IsValid == true)
           {
           

               ViewBag.aletmessage = "<script> alert('changes are saved!!!');     </script>";

           }      
           return View();
       }


    }
}
