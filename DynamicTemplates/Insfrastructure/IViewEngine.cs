using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTemplates.Insfrastructure
{
    interface IViewEngine
    {
        string Name { get; set; }

        string ViewExtension { get; set; }
    }
}
