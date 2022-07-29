using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_First_Demo.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ViewResult Index()
        {
            string myname = "My First MVC application";
            //View data is dictionary type collection that accept key value pair - prop of controller base class
            ViewData["name"] = myname;
            ViewData["products"] = new List<String>()
            {

                "Tv",
                "mobile",
                "table",
                "iphone"
            };

            //or
            //ViewData("mynameKey", myname);

            //ViewBag - ViewBag.name = value  - prop of controller base class

            ViewBag.Myname = myname;
            ViewBag.MyListData = new List<String>()
            {
                "neha",
                "pranju",
                "Pranu"
            };
            //to keep tempData on every refresh - generally we loose data if we not write keep() on refresh
            // TempData.Keep();
            //extract value - use TempData.Peek()
           // TempData.Peek("fullname");
            return View();

        }

        //TempData- data transfer from current request to subsequent request
        public ActionResult TempSession()
        {
            ViewData["fname"] = "Neha";
            ViewBag.lastname = "Moundekar";
            TempData["fullname"] = "Neha Moundekar";
            Session["Address"] = "Nagpur";

            return RedirectToAction("Index");   
        }
    }
}