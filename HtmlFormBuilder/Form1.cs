using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlBuilderCore;
using HtmlBuilderCore.Elements;
using System.IO;

namespace HtmlFormBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        HtmlPage page = new HtmlPage();
        HtmlPara para = new HtmlPara();
        HtmlImage img = new HtmlImage();
        HtmlLink lnk = new HtmlLink();
        HtmlTable table = new HtmlTable();
        HtmlRadio rad = new HtmlRadio();

        private void button1_Click(object sender, EventArgs e)
        {
            page.Title = textBox1.Text;
            para.Text = richTextBox1.Text;
            img.ImageSrc = textBox2.Text;
            lnk.LinkSrc = textBox3.Text;
            lnk.LinkText = textBox4.Text;
            table.col = Int32.Parse(textBox6.Text);
            table.row = Int32.Parse(textBox5.Text);
            string[] data = (textBox7.Text).Split(',');
            table.creatTable(data);

           if(radioButton1.Checked)
            {
                rad.value = radioButton1.Text;
               }
           else 
            {
                rad.value = radioButton2.Text;

            }
           
                             

            page.Elements.Add(img);
            page.Elements.Add(lnk);
            page.Elements.Add(para);
            page.Elements.Add(table);
            page.Elements.Add(rad);                

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var html = page.GetPageHtml();
            string path = @"C:\Users\tek3\Desktop\HtmlBuilder2.htm";
           
            // Create the file.
            using (FileStream fs = File.Create(path, 1024))
            {
                StreamWriter writer = new StreamWriter(fs);
              //   writer.WriteLine("<html><body><table border='2' width='200' height='300'><tr></tr></table></body></html>");
              
                writer.WriteLine(html.ToString());
                writer.Close();
            };

        }
    }
}
