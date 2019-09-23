using LibraryDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationEpam1
{
    public class ReviewesList
    {
        public List<Review> List { get; set; }

        public ReviewesList(List<Review> list)
        {
            List = list;
        }
    }
}