using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EducationDepartmentV1.Models;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;

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

        [HttpGet]
        public ActionResult FlowChart()
        {
            ViewBag.Message = "Video";

            return View();
        }


        [HttpPost]
        public JsonResult FlowChartFromJSON(int id)
        {
            ViewBag.Message = "Video";
            FlowChartContext flowChartContext = new FlowChartContext();
            flowChart fc = flowChartContext.flowCharts.Single(flow => flow.id == id);
            String s = fc.jsonDoc;
            System.Diagnostics.Debug.WriteLine(s);
            //var json = new JavaScriptSerializer();
            //var data = json.Deserialize<Dictionary<string, Dictionary<string, string>>[]>(s);
            
            JObject json = JObject.Parse(s);
            System.Diagnostics.Debug.WriteLine(json);
            return Json(s, JsonRequestBehavior.AllowGet);
            //return json;
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult FlowChart(flowChart requests)
        {
            if (requests == null)
            {
                System.Diagnostics.Debug.WriteLine("its null");
            }
            FlowChartContext flowChartContext = new FlowChartContext();
            flowChart fc = new flowChart();
            //fc.id  = requests.id;
            fc.jsonDoc = requests.jsonDoc;
            //Console.Write(requests.id);
            //Console.Write(requests.jsonDoc);
            System.Diagnostics.Debug.WriteLine(fc.id);
            System.Diagnostics.Debug.WriteLine(fc.jsonDoc);
            flowChartContext.flowCharts.Add(fc);
            flowChartContext.SaveChanges();
            System.Diagnostics.Debug.WriteLine("successfully added");
            ViewBag.Message = "Video";
            return View();
        }
    }
}