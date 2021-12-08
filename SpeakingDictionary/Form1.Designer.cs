
namespace SpeakingDictionary
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSpeakEnglish = new System.Windows.Forms.Button();
            this.comboBoxWord = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSpeakExplaination = new System.Windows.Forms.Button();
            this.buttonSpeakMeaning = new System.Windows.Forms.Button();
            this.textBoxExplaination = new System.Windows.Forms.TextBox();
            this.textBoxMeaning = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonSpeakEnglish);
            this.panel1.Controls.Add(this.comboBoxWord);
            this.panel1.Location = new System.Drawing.Point(13, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 499);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Word";
            // 
            // buttonSpeakEnglish
            // 
            this.buttonSpeakEnglish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSpeakEnglish.BackgroundImage")));
            this.buttonSpeakEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSpeakEnglish.Location = new System.Drawing.Point(158, 12);
            this.buttonSpeakEnglish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSpeakEnglish.Name = "buttonSpeakEnglish";
            this.buttonSpeakEnglish.Size = new System.Drawing.Size(29, 30);
            this.buttonSpeakEnglish.TabIndex = 4;
            this.buttonSpeakEnglish.UseVisualStyleBackColor = true;
            // 
            // comboBoxWord
            // 
            this.comboBoxWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxWord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxWord.FormattingEnabled = true;
            this.comboBoxWord.Location = new System.Drawing.Point(11, 50);
            this.comboBoxWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxWord.Name = "comboBoxWord";
            this.comboBoxWord.Size = new System.Drawing.Size(177, 441);
            this.comboBoxWord.Sorted = true;
            this.comboBoxWord.TabIndex = 0;
            this.comboBoxWord.SelectedIndexChanged += new System.EventHandler(this.comboBoxWord_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonSpeakExplaination);
            this.panel2.Controls.Add(this.buttonSpeakMeaning);
            this.panel2.Controls.Add(this.textBoxExplaination);
            this.panel2.Controls.Add(this.textBoxMeaning);
            this.panel2.Location = new System.Drawing.Point(231, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 498);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Explaination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Meaning";
            // 
            // buttonSpeakExplaination
            // 
            this.buttonSpeakExplaination.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSpeakExplaination.BackgroundImage")));
            this.buttonSpeakExplaination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSpeakExplaination.Location = new System.Drawing.Point(432, 80);
            this.buttonSpeakExplaination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSpeakExplaination.Name = "buttonSpeakExplaination";
            this.buttonSpeakExplaination.Size = new System.Drawing.Size(29, 30);
            this.buttonSpeakExplaination.TabIndex = 2;
            this.buttonSpeakExplaination.UseVisualStyleBackColor = true;
            // 
            // buttonSpeakMeaning
            // 
            this.buttonSpeakMeaning.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSpeakMeaning.BackgroundImage")));
            this.buttonSpeakMeaning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSpeakMeaning.Location = new System.Drawing.Point(432, 11);
            this.buttonSpeakMeaning.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSpeakMeaning.Name = "buttonSpeakMeaning";
            this.buttonSpeakMeaning.Size = new System.Drawing.Size(29, 30);
            this.buttonSpeakMeaning.TabIndex = 3;
            this.buttonSpeakMeaning.UseVisualStyleBackColor = true;
            // 
            // textBoxExplaination
            // 
            this.textBoxExplaination.Location = new System.Drawing.Point(15, 116);
            this.textBoxExplaination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxExplaination.Multiline = true;
            this.textBoxExplaination.Name = "textBoxExplaination";
            this.textBoxExplaination.Size = new System.Drawing.Size(447, 374);
            this.textBoxExplaination.TabIndex = 1;
            // 
            // textBoxMeaning
            // 
            this.textBoxMeaning.Location = new System.Drawing.Point(15, 49);
            this.textBoxMeaning.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMeaning.Name = "textBoxMeaning";
            this.textBoxMeaning.Size = new System.Drawing.Size(447, 20);
            this.textBoxMeaning.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(729, 529);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Từ điển nói";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxWord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxExplaination;
        private System.Windows.Forms.TextBox textBoxMeaning;
        private System.Windows.Forms.Button buttonSpeakExplaination;
        private System.Windows.Forms.Button buttonSpeakMeaning;
        private System.Windows.Forms.Button buttonSpeakEnglish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

