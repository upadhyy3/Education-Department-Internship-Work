using EducationDepartmentV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducationDepartmentV1.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        [HttpGet]
        public ActionResult Example1()
        {
            return View();
        }

        public class CreateExampleRequests
        {
            public String id { get; set; }
            public String contetn { get; set; }
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Example1(CreateExampleRequests requests)
        {
            var example = new Example();
            //example.id = requests.id;
            example.contetn = requests.contetn;
            example.id = 1;
       //     example.lastDate = DateTime.Now;
            var db = new  ExamplDBContext();
           // db.Example.Attach(example);
           // db.Entry(example).State = System.Data.Entity.EntityState.Added;
             db.Example.Add(example);
            db.SaveChanges();

            //db.Example.Add(example);
            //db.SaveChanges();
            return View();
        }

        public ActionResult Example2()
        {
            return View();
        }

        public ActionResult Example3()
        {
            return View();
        }
    }
}