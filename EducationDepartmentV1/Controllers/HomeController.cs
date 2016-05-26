using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducationDepartmentV1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult index()
        {
            return View();
        }

        public ActionResult Faculty()
        {
            ViewBag.Message = "Your Faculty page.";

            return View();
        }

        public ActionResult Contact()
        {
                ViewBag.Message = "Your contact page.";

                return View();
        }

        public ActionResult PWE()
        {
            ViewBag.Message = "Practice With Example";

            return View();
        }

        public ActionResult ExampleRepository()
        {
            ViewBag.Message = "Example Repository";

            return View();
        }

        public ActionResult Video()
        {
            ViewBag.Message = "Video";

            return View();
        }

        //public ActionResult FlowChart()
        //{
        //    ViewBag.Message = "Video";

        //    return View();
        //}

        //public ActionResult Example1()
        //{
        //    ViewBag.Message = "Video";

        //    return View();
        //}
    }
}