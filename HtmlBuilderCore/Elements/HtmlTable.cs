﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilderCore.Elements
{
    public class HtmlTable : IHtmlElement
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public List<object> RowsList { get; set; }
               
        public HtmlTable()
        {
            RowsList = new List<object>();
        }
        public string SingleRowToList = "";
        public string Singular;

        public void FillData(params string[] rowdata)
        {
            
            int i, j;
           
            if (rowdata.Length > (this.Columns * this.Rows))
            {
                throw new InvalidInputException("Please Enter Valid Input");
            }
            else
            {
                int c = 0;
                int RowDataLength = rowdata.Length;
                for (i = 0; i < this.Rows; i++)
                {
                    SingleRowToList += "<tr>";
                    for (j = 0; j < this.Columns; j++)
                    {
                        if (RowDataLength != 0)
                        {
                            SingleRowToList += "<td>" + rowdata[c++] + "</td>";
                            RowDataLength--;
                        }
                        else
                        {
                            SingleRowToList += "<td></td>";
                        }
                    }
                    SingleRowToList += "</tr>";
                    RowsList.Add(SingleRowToList);
                    SingleRowToList = "";
                }
            }
         }
        public string GetHtmlString()
        {
            foreach (object TableData in RowsList)
            {
                SingleRowToList += TableData;
            }
            return string.
                Format("<table border='1'>{0}</table>", this.SingleRowToList);
        }
    }
}
