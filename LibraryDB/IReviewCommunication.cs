using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDB
{
    interface IReviewCommunication
    {
        ICollection<Review> GetReviews();

        void CreateReview(string name, string text);
    }
}