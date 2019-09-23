using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDB
{
    public class CommunicationWithController : IArticleCommunication, IReviewCommunication
    {
        // Method gets all articles from database
        public ICollection<Article> GetArticles()
        {
            using (var ctx = new BlogContext("BlogContext"))
            {
                ICollection<Article> articles = ctx.Articles.ToList();
                return articles;
            }
        }

        // Method gets all reviews from database
        public ICollection<Review> GetReviews()
        {
            using (var ctx = new BlogContext("BlogContext"))
            {
                List<Review> reviews = ctx.Reviewes.ToList();
                return reviews;
            }
        }

        // Add new review in database
        public void CreateReview(string name, string text)
        {
            using (var ctx = new BlogContext("BlogContext"))
            {
                ctx.Reviewes.Add(
                    new Review
                    {
                        Name = name,
                        Text = text,
                        Date = DateTime.Now
                    });
                ctx.SaveChanges();
            }
        }
    }
}