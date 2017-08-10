using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController:Controller
    {

        public ActionResult Detail()
        {

            ViewBag.SeriesTitle = "The amazing spoder-ma";
            ViewBag.IssueNumber = 700;
            ViewBag.Descripiton = "<p> Final Issue!</p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan slott",
                "Pencil: humberto",
                "Inks:victor olababa",
                "Letters: Chris",



                 };

            return View();
        }

    }
}