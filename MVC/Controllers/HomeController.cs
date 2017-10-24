﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using Microsoft.AspNetCore.Http;



namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
     
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            int[] array = new int[] { 10, 20, 30, 40 };
            int[] Modes = { 1, 1, 1, 1 };
           
            ViewData["Modes"] = Modes;

            ViewBag.Collection = array;
            HttpContext.Session.SetString("UserData", "sdfsdf");
            return View();
        }

        [HttpPost]
        public IActionResult GetAbout()
        {
            string firstName = HttpContext.Request.Form["name"];
            return Ok(firstName);
        }

        public IActionResult Contact()
        {
            
            ViewData["Message"] = "Time to play the game";
            ViewData["ses"]=HttpContext.Session.GetString("UserData");
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
