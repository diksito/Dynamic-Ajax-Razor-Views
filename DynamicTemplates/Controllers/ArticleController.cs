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
        // GET api/<controller>
        public string Get()
        {
            string date = DateTime.UtcNow.ToString();
            Article article = new Article
            {
                Title = "Dummy " + date,
                Description = "Dummy description " + date,
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

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}