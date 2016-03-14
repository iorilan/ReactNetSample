using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReactNetSample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        private static List<CommentModel> _comments;

        public ActionResult Comments()
        {
            if (_comments.Count == 0)
            {
                _comments = new List<CommentModel>
                {
                    new CommentModel
                    {
                        Author = "Daniel Lo Nigro",
                        Text = "Hello ReactJS.NET World!"
                    },
                    new CommentModel
                    {
                        Author = "Pete Hunt",
                        Text = "This is one comment"
                    },
                    new CommentModel
                    {
                        Author = "Jordan Walke",
                        Text = "This is *another* comment"
                    },
                };
            }
            return Json(_comments ,JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddComment(CommentModel comment)
        {
            _comments.Add(comment);
            return Content("Success :)");
        }
    }

    public class CommentModel
    {
        public string Author { get; set; }
        public string Text { get; set; }
    }
}