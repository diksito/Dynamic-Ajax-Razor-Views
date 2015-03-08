using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicTemplates.Insfrastructure
{
    /// <summary>
    /// 
    /// </summary>
    public class RazorViewEngineParser : ViewEngineParser
    {
        public override ViewEngine Engine { get; set; }
        private string Controller { get; set; }
        private string Action { get; set; }
        private string Data { get; set; }

        public override object Model { get; set; }
        public RazorViewEngineParser(ViewEngine engine, Object model)
        {
            this.Engine = engine;
            this.Model = model;
        }

        public override string ToString()
        {
            return Data;
        }

        public override void Parse(string controller, string action)
        {
            this.Controller = controller;
            this.Action = action;

            string fullViewPath = System.Web.HttpContext.Current.Server.MapPath(getViewPath());
            string viewContent = System.IO.File.ReadAllText(fullViewPath);

            // Remove model declaration
            string modelDeclaration = "@model " + this.Model.GetType();
            viewContent = viewContent.Replace(modelDeclaration, string.Empty);

            // Bind data
            foreach (var prop in this.Model.GetType().GetProperties())
                viewContent = viewContent.Replace("@Model." + prop.Name, prop.GetValue(this.Model, null).ToString()); // bind data

            Data = viewContent;
        }

        private string getViewPath()
        {
            string viewFullPath = string.Empty;

            if (string.IsNullOrEmpty(this.Controller))
                viewFullPath = "~/Views/Shared/" + this.Action + this.Engine.ViewExtension;
            else if (!string.IsNullOrEmpty(this.Controller) && !string.IsNullOrEmpty(this.Action))
                viewFullPath = "~/Views/" + this.Controller + "/" + this.Action + this.Engine.ViewExtension;

            return viewFullPath;
        }
    }
}