using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View("OurCompanyProduct");
        }
        public ActionResult Contact()
        {
            ViewBag.TollFree = "123-123-123";
            return View();
        }
        public ActionResult GetEmpName(int EmpId)
        {
            var employees = new[]
            {
                new {EmpId=1,EmpName="Scott",Salary=8000},
                new {EmpId=2,EmpName="Smith",Salary=2540},
                new {EmpId=3,EmpName="Allen",Salary=9400}

            };
            string matchEmpName = null;
            foreach (var item in employees)
            {
                if (item.EmpId == EmpId)
                {
                    matchEmpName = item.EmpName;
                }
            }

            // return new ContentResult() { content=matchEmpName,ContentType="text/plain"}; 
            return Content(matchEmpName, "text/plain");
        }
        public ActionResult GetPaySlip(int EmpId)
        {
            String fileName = "~/PaySlip" + EmpId + ".pdf";
            return File(fileName, "application/pdf");
        }
        public ActionResult EmpFacebookPage(int EmpId)
        {
            string fbUrl = "http://www.facebook.com/Emp" + EmpId;
            return Redirect(fbUrl);
        }
        public ActionResult StudentDetails()
        {
            ViewBag.StudentId = 101;
            ViewBag.StudentName = "Scott";
            ViewBag.Marks = 90;
            ViewBag.NoOfSem = 6;
            ViewBag.Subject = new List<string>() { "Maths", "Physics", "Chemistry" };

            return View();
        }
        public ActionResult RequestExample()
        {
            ViewBag.Url = Request.Url;
            ViewBag.PhysicalApplicationPath = Request.PhysicalApplicationPath;
            ViewBag.Path = Request.Path;
            ViewBag.BrowserType = Request.Browser.Type;
            ViewBag.QuerryString = Request.QueryString["n"];
            ViewBag.Headers = Request.Headers["Accept"];
            ViewBag.HttpMethod = Request.HttpMethod;

            return View();
        }
        public ActionResult ResponseExample()
        {
            Response.Write("Hello from Response Example");
            Response.ContentType = "text/plain";
            return View();
        }
    }
}