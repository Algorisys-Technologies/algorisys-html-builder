using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilderCore.Elements
{
    public class HtmlPwdTextbox:IHtmlElement
    {
        public string inputtype1 { get; set; }
        public string name1 { get; set; }

        public string GetHtmlString()
        {
            return string.Format("<input type='{0}' value='{1}'/>", this.inputtype1, this.name1);
        }
    }
}
