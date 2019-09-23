using LibraryDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplicationEpam1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CommunicationWithController cwc = new CommunicationWithController();
            ArticlesList articles = new ArticlesList(cwc.GetArticles() as List<Article>);
            articles.List.Sort();
            return View(articles);
        }

        public ActionResult Guest()
        {
            CommunicationWithController cwc = new CommunicationWithController();
            ReviewesList reviewes = new ReviewesList(cwc.GetReviews() as List<Review>);
            reviewes.List.Sort();
            return View(reviewes);
        }

        [HttpPost]
        public ActionResult Guest(FormCollection form)
        {
            CommunicationWithController cwc = new CommunicationWithController();
            cwc.CreateReview(form["Name"], form["Text"]);
            ReviewesList reviewes = new ReviewesList(cwc.GetReviews() as List<Review>);
            reviewes.List.Sort();
            return View(reviewes);
        }

        public ActionResult Profile(FormCollection form)
        {
            // if user answers questions in form, other form will be opened
            if (HttpContext.Request.HttpMethod == "POST")
            {
                ViewData["Name"] = form["nameQuestion"];
                ViewData["Age"] = form["ageQuestion"];
                ViewData["Dish"] = form["dishQuestion"];
                ViewData["Fruit"] = form["fruit"];
                ViewData["Vegetable"] = form["vegetable"];
                List<string> badHabits = new List<string>();
                if (form["badHabit1"] != null)
                    badHabits.Add(form["badHabit1"]);
                if (form["badHabit2"] != null)
                    badHabits.Add(form["badHabit2"]);
                if (form["badHabit3"] != null)
                    badHabits.Add(form["badHabit3"]);
                if (badHabits.Count > 0)
                {
                    ViewData["BadHabits"] = badHabits;
                }

                return View("ProfileReady");
            }

            return View();
        }
    }
}