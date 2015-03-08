using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicTemplates.Insfrastructure
{
    public abstract class ViewEngineParser
    {
        public abstract ViewEngine Engine { get; set; }
        public abstract Object Model { get; set; }

        public abstract void Parse(string viewPath, string b);
    }
}