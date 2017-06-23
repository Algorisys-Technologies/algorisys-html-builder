using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilderCore.Elements
{
  public class HtmlRadio : IHtmlElement
    {
        public string inputtype1 { get; set; }
        public string value { get; set; }
   
        public string GetHtmlString()
        {
            return string.Format("<p>{0}</p>",this.value);
        }
    }
}
