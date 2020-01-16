using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace Getmainlbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "http://mydiba.me/tt6394270/";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load(url);
            var body = document.DocumentNode.SelectNodes("//body").Single();
            foreach (HtmlAgilityPack.HtmlNode div in body.SelectNodes("//div"))
            {
                var classValue = div.Attributes["class"] == null ? null : div.Attributes["class"].Value;

                if (classValue != null)
                    if (classValue.Contains("maindl"))
                    {

                        var lk = div.Descendants("a").FirstOrDefault();
                        
                        var hreff = lk.GetAttributeValue("href", "");
                        //write innerText into a table at place [i][column1]
                    }

            }




        }
    }
}
