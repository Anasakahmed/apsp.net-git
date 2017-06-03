using MvcApplication23.ModelClass;
using MvcApplication23.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication23.Controllers
{
    public class adminController : Controller
    {
        //
        // GET: /admin/

        public ActionResult admin()
        {
            studentviewmodel stvm = new studentviewmodel();
            List<students> li = stvm.getallemployees();
            return View(li);
        }

    }
}
