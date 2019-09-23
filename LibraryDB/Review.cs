using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDB
{
    public class Review : IComparable
    {
        [Key]
        public int Id { get; set; }
        [MinLength(3)]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        [MinLength(20)] public string Text { get; set; }

        public int CompareTo(object obj)
        {
            Review review = obj as Review;
            if (obj != null)
            {
                if (review.Date > this.Date)
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