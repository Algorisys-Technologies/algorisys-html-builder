using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilderCore.Elements
{
   public class HtmlTextBox : IHtmlElement
    {

        public string inputtype { get; set; }
        public string name { get; set; }


        public string GetHtmlString()
        {
            return string.Format("<input type='{0}' name='{1}'/>",this.inputtype,this.name);
        }
    }
}
