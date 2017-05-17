using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            string text = "lalallala";

            return View();
        }
        public ActionResult Read(string path)
        {
            string text = System.IO.File.ReadAllText(path, System.Text.Encoding.UTF8);
            return Json(text, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Write(string JsonContent)
        {
            var content = JsonConvert.DeserializeObject<Content>(JsonContent);

            System.IO.File.WriteAllText(content.path, content.text);
            return Json(content.text, JsonRequestBehavior.AllowGet);
        }
    }
    public class Content
    {
        public string text { get; set; }
        public string path { get; set; }
    }

}
