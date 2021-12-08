using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakingDictionary
{
    class Speaker
    {
        private WebBrowser wb;

        public WebBrowser Web { get => wb; set => wb = value; }

        public Speaker(WebBrowser web)
        {
            Web = web;
        }

        private void SetText(string data)
        {
            HtmlElement element = Web.Document.GetElementById("text");
            element.SetAttribute("value", data);
        }

        private void PlayButton()
        {
            HtmlElement button = wb.Document.GetElementById("playbutton");
            button.InvokeMember("click");
        }

        public void Speak(string data)
        {
            //SetText(data);
            //PlayButton();
        }

        public static WebBrowser CreateHiddenWebBrowser()
        {
            WebBrowser wb = new WebBrowser();
            wb.Width = 0;
            wb.Height = 0;
            wb.Visible = false;
            wb.ScriptErrorsSuppressed = true;
            return wb;
        }

        public static Speaker GetEnglishSpeaker()
        {
            WebBrowser wb = CreateHiddenWebBrowser();
            wb.Navigate(Links.EnglishLink);
            return new Speaker(wb);
        }

        public static Speaker GetVietnameseSpeaker()
        {
            WebBrowser wb = CreateHiddenWebBrowser();
            wb.Navigate(Links.VietnameseLink);
            return new Speaker(wb);
        }
    }
}
