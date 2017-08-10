using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {

        // Important for MVc

            // First step towards creating Data-modelling 
            // Process of structure data first=== Data model Nounce is noun or class name or data model 
            // here first noun is comic book we can define fields or properties 

        public int ID { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }

        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }


        public bool Favorite { get; set; }



        public string DisplayText
        {
            get
            {
                return SeriesTitle + "# " + IssueNumber;
            }
        }



        // series-title-issuenumber.jpg   // provies information how we have created whole string for this 
        // Created customer function or method for creating title using string concatanation


        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg";
            }
        }







    }
}