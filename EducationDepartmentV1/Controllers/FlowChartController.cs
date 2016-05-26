using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EducationDepartmentV1.Models;

namespace EducationDepartmentV1.Controllers
{
    public class FlowChartController : Controller
    {
        // GET: FlowChart
        //public ActionResult flowChartView()
        //{
        //    flowChart fc = new flowChart();
        //    return View();
        //}

        //[HttpGet]
        public ActionResult FlowChart()
        {
            ViewBag.Message = "Video";

            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult FlowChart(flowChart requests)
        {
            if (requests == null)
            {
                System.Diagnostics.Debug.WriteLine("its null");
            }
            flowChart fc = new flowChart();
            fc.id  = requests.id;
            fc.jsonDoc = requests.jsonDoc;
            //Console.Write(requests.id);
            //Console.Write(requests.jsonDoc);
            System.Diagnostics.Debug.WriteLine(fc.jsonDoc);
            ViewBag.Message = "Video";

            return View();
        }
    }
}