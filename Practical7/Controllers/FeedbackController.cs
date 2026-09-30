using Practical7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical7.Controllers
{
    public class FeedbackController : Controller
    {
        static List<Feedback> feedbackList = new List<Feedback>();

        // GET: Feedback
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(Feedback f1)
        {
            feedbackList.Add(f1);
            return RedirectToAction("List");        
        }

        public ActionResult List()
        {
            return View(feedbackList);
        }
    }
}