﻿using FIT5032_MyCodeSnippet.Models;
using FIT5032_MyCodeSnippet.Models.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;

namespace FIT5032_MyCodeSnippet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            // I commented this line out 
            //ViewBag.Message = "Your application description page."; 

            // I created an instance of the Hello object 
            Hello hello = new Hello();

            // I assigned the ViewBag.Message to the result 
            ViewBag.Message = hello.GetHello();

            ExampleDictionary ed = new ExampleDictionary();
            ed.Example();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}