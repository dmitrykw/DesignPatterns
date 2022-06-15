using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodExample
{
    internal abstract class HTMLTemplate
    {
        protected string _htmlDocument = string.Empty;
        protected void SetHTMLHeader()
        {
            _htmlDocument +=
                "<html><body>";
        }

        protected abstract void SetDocumentHeader();
        protected void SetHTMLContent(string content)
        {
            _htmlDocument += content;
        }

        protected void SetHTMLFooter()
        {
            _htmlDocument +=
                "</body></html>";
        }

        public string GetHTML(string content)
        {
            SetHTMLHeader();
            SetDocumentHeader();
            SetHTMLContent(content);
            SetHTMLFooter();

            return _htmlDocument;
        }
    }
}
