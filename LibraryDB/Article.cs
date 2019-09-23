using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDB
{
    public class Article : IComparable
    {
        [Key]
        public int Id { get; set; }
        [MinLength(5)]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }

        public int CompareTo(object obj)
        {
            Article article = obj as Article;
            if (obj != null)
            {
                if (article.Date > this.Date)
                    return 1;
                else
                    return -1;
            }
            else
            {
                throw new Exception("Can't compare two object's''");
            }
        }
    }
}