using MvcApplication23.ModelClass;
using MvcApplication23.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
       

        public ActionResult orientation()
        {
            return View();
        }
        [HttpPost]
       
     
        
        
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
      public ActionResult admission(students stu, HttpPostedFileBase file, HttpPostedFileBase file2)
        {
            string path1="null", path2="null";
          
          if (file==null)
            {
                ViewBag.alertmessage = "<script> alert('Matric document is Required!!!');     </script>";
            }
            else if (file2 == null)
            {
                ViewBag.alertmessage = "<script> alert('Inter Document is Required!!!');     </script>";
            }


          else
          {

              if (file != null && file.ContentLength > 0)
              {
                  string fileExtension = System.IO.Path.GetExtension(file.FileName);

                  if (fileExtension.ToLower() != ".jpg" && fileExtension.ToLower() != ".png")
                  {
                      ViewBag.alertmessage = "<script> alert('Matric document should be in proper format i.e (jpg/png)!!!');     </script>";
                  }
                  else
                  {
                       path1 = Server.MapPath("~/Content/" + file.FileName);
                      file.SaveAs(path1);
                      ViewBag.path = path1;
                  }
              }


              if (file2 != null && file2.ContentLength > 0)
              {
                  string fileExtension = System.IO.Path.GetExtension(file2.FileName);

                  if (fileExtension.ToLower() != ".jpg" && fileExtension.ToLower() != ".png")
                  {
                      ViewBag.alertmessage = "<script> alert('Inter document should be in proper format i.e (jpg/png)!!!');     </script>";
                  }
                  else
                  {
                       path2 = Server.MapPath("~/Content/" + file2.FileName);
                      file2.SaveAs(path2);
                      ViewBag.path2 = path2;
                  }
              }



              if (ModelState.IsValid == true)
              {


                  studentviewmodel stvm = new studentviewmodel();
                  string s = stvm.insert_loginmethod(stu);
                  stvm.insert_ssc(stu, s);
                  stvm.insert_hsc(stu, s);
                  stvm.insert_filepath(path1,path2, s);
                  ViewBag.alertmessage = "<script> alert('Data Sucessfully uploaded!!!');     </script>";
                  return RedirectToAction("Index");

              }



          }

          return View();
          
         
            
        }



      








      


    }
}
