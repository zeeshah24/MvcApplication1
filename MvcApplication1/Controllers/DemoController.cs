using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class DemoController : Controller
    {
        //
        // GET: /Demo/

        public String Index()
        {
            return "Just to call default action.";
        }
        public ActionResult CallStudent()
        {
            Student shah = new Student();
            shah.StudentID = 1;
            shah.FirstName = "Shah";
            shah.LastName = "Khan";
            return View(shah);
        }
        public string MyCall(int id)
        {
            Student student = new Student();
            if (id == 1)
            {
                student.StudentID = 1;
                student.FirstName = "Shah";
                student.LastName = "Khan";
            }
            else
            {

                //Student naren = new Student();
                student.StudentID = 2;
                student.FirstName = "Narendra";
                student.LastName = "Dagwar";
            }
            return "This method is called from DemoController MyCall function";
        }
    }
}
