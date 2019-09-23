using LibraryDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationEpam1
{
    public class ArticlesList
    {
        public List<Article> List { get; set; }

        public ArticlesList(List<Article> list)
        {
            List = list;
        }
    }
}