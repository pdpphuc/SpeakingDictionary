using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakingDictionary
{
    public partial class Form1 : Form
    {
        private DictionaryManager dictionary;
        //private Speaker EnglishSpeaker;
        //private Speaker VietnameseSpeaker;

        private bool loadEnSpeakerCompleted = false, loadVnSpeakerCompleted = false;
        public Form1()
        {
            InitializeComponent();
            //LoadCompleted();

            textBoxMeaning.ReadOnly = true;
            textBoxExplaination.ReadOnly = true;

            dictionary = new DictionaryManager();
            dictionary.LoadDataToComboBox(comboBoxWord);

            //EnglishSpeaker = Speaker.GetEnglishSpeaker();
            //EnglishSpeaker.Web.DocumentCompleted += WebEn_DocumentCompleted;

            //VietnameseSpeaker = Speaker.GetVietnameseSpeaker();
            //VietnameseSpeaker.Web.DocumentCompleted += WebVn_DocumentCompleted;

            //this.Controls.Add(EnglishSpeaker.Web);
            //this.Controls.Add(VietnameseSpeaker.Web);
        }

        private void LoadCompleted()
        {
            this.Enabled = loadEnSpeakerCompleted && loadVnSpeakerCompleted;
        }

        private void WebVn_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            loadVnSpeakerCompleted = true;
            LoadCompleted();
        }

        private void WebEn_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            loadEnSpeakerCompleted = true;
            LoadCompleted();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Nếu người dùng không muốn thoát
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }
            dictionary.Serialize();
        }

        private void comboBoxWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;

            if(combo.DataSource == null)
            {
                return;
            }

            DictionaryData data = combo.SelectedItem as DictionaryData;
            textBoxMeaning.Text = data.Meaning;
            textBoxExplaination.Text = data.Explaination;
        }

        //private void buttonSpeakEnglish_Click(object sender, EventArgs e)
        //{
        //    EnglishSpeaker.Speak((comboBoxWord.SelectedItem as DictionaryData).Key);
        //}

        //private void buttonSpeakMeaning_Click(object sender, EventArgs e)
        //{
        //    VietnameseSpeaker.Speak(textBoxMeaning.Text);
        //}

        //private void buttonSpeakExplaination_Click(object sender, EventArgs e)
        //{
        //    VietnameseSpeaker.Speak(textBoxExplaination.Text);
        //}
    }
}
