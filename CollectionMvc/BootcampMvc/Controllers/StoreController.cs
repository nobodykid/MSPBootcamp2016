﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BootcampMvc.Models;

namespace BootcampMvc.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            // simple Controller return value to View, access by typing /Store/Index into URL
            return "Hello from Store.Index";
        }

        public string Browse(string category)
        {
            // simple Web with query, access by typing /Store/SampleQuery?category={your input}
            return HttpUtility.HtmlEncode("Hello from SampleQuery with category: " + category);
        }

        public ActionResult Home()
        {
            // param empty = View equal method name
            // return View(); 

            // if filled, will called that View (only if inside same Controller)
            //return View("About");

            //if you want to refer to Views from different Controller
            return View("~/Views/Home/About.cshtml");
        }

        public ActionResult DataSample()
        {
            // using ViewData (array-type)
            ViewData["event"] = "MSP Bootcamp";
            ViewData["place"] = "Hotel Neo";

            // using ViewBag (property-type)
            ViewBag.Event = "MSP Bootcamp";
            ViewBag.Place = "Hotel Neo";

            // using simple array of data
            var books = new List<string>() { "ASP.NET", "SQL Server", "Windows 10" };
            ViewBag.booklist = books;

            // using collection of datas        
            List<Participant> participants = new List<Participant>()
            {
                new Participant() {Id=1, Name="Muhamad Iqbal", Region="Bodeta" },
                new Participant() {Id=2, Name="Ade Haryanto", Region="Sumatera" }
            };

            // change content of bracket with data you want show at View
            return View(participants);
        }

        public ViewResult UsePartialView()
        {
            List<Participant> participants = new List<Participant>()
            {
                new Participant() {Id=1, Name="Muhamad Iqbal", Region="Bodeta" },
                new Participant() {Id=2, Name="Ade Haryanto", Region="Sumatera" }
            };

            return View(participants);
        }
    }
}