using DynamicTemplates.Insfrastructure;
using DynamicTemplates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DynamicTemplates.Controllers
{
    public class ArticleController : ApiController
    {
        // GET api/Article
        public string Get(string title, string description)
        {
            string date = DateTime.UtcNow.ToString();
            Article article = new Article
            {
                Title = title,
                Description = description,
                ArticleId = 1,
                PublishedDate = DateTime.UtcNow
            };

            ViewEngine engine = new ViewEngine{
                Name = "Razor",
                ViewExtension = ".cshtml"
            };
            RazorViewEngineParser parser = new RazorViewEngineParser(engine, article);
            parser.Parse("Home", "_PartialArticle");

            return parser.ToString();
        }
    }
}