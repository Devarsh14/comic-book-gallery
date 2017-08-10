using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {

        public ActionResult Detail()
        {
            var comicBook = new ComicBook();
            {
                comicBook.SeriesTitle = "The amazing spoder-ma";
                comicBook.IssueNumber = 700;

                comicBook.DescriptionHtml = "<p> Final Issue!</p>";

                comicBook.Artists = new Artist[]{

                    new Artist(){Name="Dan Slott", Role="Script"},
                    new Artist(){Name="Huberto Ramos", Role="Pencils"},
                    new Artist(){Name="Victor Olazaba", Role="Inks"},
                    new Artist(){Name="Chris", Role="Letters"},
                };





            }







            return View(comicBook);
        }

    }
}
