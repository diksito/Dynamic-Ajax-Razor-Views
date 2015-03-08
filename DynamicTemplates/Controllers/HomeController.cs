using DynamicTemplates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicTemplates.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Article> articles = new List<Article>();

            for (int i = 0; i < 5; i++)
            {
                articles.Add(new Article
                {
                    ArticleId = i,
                    Title = "Hello " + i,
                    Description = "World " + i,
                });
            }

            return View(articles);
        }
    }
}