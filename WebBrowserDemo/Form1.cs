using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserDemo
{
    public partial class Form1 : Form
    {
        WebBrowser wb;
        public Form1()
        {
            InitializeComponent();
            textBoxAddress.Text = "https://responsivevoice.org/text-to-speech-languages/uk-english-text-to-speech/";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            wb = new WebBrowser();
            wb.Width = 1400;
            wb.Height = 900;
            wb.ScriptErrorsSuppressed = true;
            wb.DocumentCompleted += Wb_DocumentCompleted;
            panelWebBrowser.Controls.Add(wb);
        }

        private void Wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //MessageBox.Show("Done!");
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string link = textBoxAddress.Text;

            if(wb == null || link == null || link.Equals(""))
            {
                return;
            }
            wb.Navigate(new Uri(link));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HtmlElement textArea = wb.Document.GetElementById("text");
            textArea.SetAttribute("value", "Hello");

            HtmlElement button = wb.Document.GetElementById("playbutton");
            button.InvokeMember("click");
        }
    }
}
