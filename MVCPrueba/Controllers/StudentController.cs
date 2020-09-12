using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPrueba.Models;

namespace MVCPrueba.Controllers
{
    public class StudentController : Controller
    {
        // GET: Estudent


        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult createStudent(Student std)
        {
            Models.StudentService.Add(std);
            //context.Students.Add(std);
            //context.SaveChanges();
            string message = "SUCCESS";
            return Json(new { Messag = message, JsonRequestBehavior.AllowGet });
        }

        
        public JsonResult getStudent(string myid)
        {
            List<Student> students;
            students = StudentService.Students.ToList();
            return Json(students, JsonRequestBehavior.AllowGet);
        }
    }
}