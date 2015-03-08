using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicTemplates.Insfrastructure
{
    public class ViewEngine : IViewEngine
    {
        public string Name { get; set; }
        public string ViewExtension { get; set; }
    }
}