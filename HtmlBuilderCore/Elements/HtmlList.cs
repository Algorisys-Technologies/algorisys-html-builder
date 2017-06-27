using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilderCore.Elements
{
    public class HtmlList : IHtmlElement
    {
        public string ListType { get; set; }
        public string Pattern { get; set; }
        public List<string> DataList { get; set; }
        public HtmlList()
        {
            DataList = new List<string>();
        }
        public string ListItem = "";
        public void AddData(string[] data)
        {
            foreach (string x in data)
                DataList.Add(x);
        }        

        public string GetHtmlString()
        {
            foreach(string x in DataList)            
                ListItem += $"<li>{x}</li>";
            

            if(ListType == "UnOrdered List")
                 return string.Format($"<ul style='list-style-type:{Pattern}'>{ListItem}</ul>");
            else
                return string.Format($"<ol Type='{Pattern}'>{ListItem}</ol>");
        }
    }
}
