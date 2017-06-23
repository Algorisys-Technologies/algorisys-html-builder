using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HtmlBuilderCore.Elements
{
    public class HtmlTable : IHtmlElement
    {
        public int row { get; set; }
        public int col { get; set; }

        string format = "";
        public void creatTable(params string[] data)
        {

            int k = 0;
            try
            {
                for (int i = 0; i < this.row; i++)
                {

                    format += "<tr>";
                    for (int j = 0; j < this.col; j++)
                    {
                        format += "<td>" + data[k++] + "</td>";
                    }
                    format += "</tr>";
                }
           }
            catch(Exception e)
            {
            
            }


        }

        public string GetHtmlString()
        {
            return string.Format("<table border='1'>{0}</table>",this.format);
        }
    }
}
