using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodExample
{
    internal class MyHTML1 : HTMLTemplate
    {
        protected override void SetDocumentHeader()
        {
            _htmlDocument += "<H1>This is the MyHTML1 template document header</H1>";
        }
     
    }
}
