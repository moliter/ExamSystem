
namespace ExamSystem.TeaFrm
{
    partial class AddQuestionFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuestionFrm));
            this.questionTypeLab = new System.Windows.Forms.Label();
            this.questionTypeCbo = new System.Windows.Forms.ComboBox();
            this.questionStemLab = new System.Windows.Forms.Label();
            this.questionStemTxt = new System.Windows.Forms.RichTextBox();
            this.AddChoicePanel = new System.Windows.Forms.Panel();
            this.questionAnswerCbo = new System.Windows.Forms.ComboBox();
            this.questionAnswerLab = new System.Windows.Forms.Label();
            this.questionOptionDLab = new System.Windows.Forms.Label();
            this.questionOptionCLab = new System.Windows.Forms.Label();
            this.questionOptionBLab = new System.Windows.Forms.Label();
            this.questionOptionALab = new System.Windows.Forms.Label();
            this.questionOptionDTxt = new System.Windows.Forms.RichTextBox();
            this.questionOptionCTxt = new System.Windows.Forms.RichTextBox();
            this.questionOptionBTxt = new System.Windows.Forms.RichTextBox();
            this.questionOptionATxt = new System.Windows.Forms.RichTextBox();
            this.AddQuestionSubmitBtn = new System.Windows.Forms.Button();
            this.AddQuestionReset = new System.Windows.Forms.Button();
            this.questionOptionLab = new System.Windows.Forms.Label();
            this.AddTxtquestionPanel = new System.Windows.Forms.Panel();
            this.questionTxtResetBtn = new System.Windows.Forms.Button();
            this.questionTxtSubmitBtn = new System.Windows.Forms.Button();
            this.questionAnswerTxtTxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.questionStemTxtTxt = new System.Windows.Forms.RichTextBox();
            this.questionTxtStemLab = new System.Windows.Forms.Label();
            this.AddChoicePanel.SuspendLayout();
            this.AddTxtquestionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionTypeLab
            // 
            this.questionTypeLab.AutoSize = true;
            this.questionTypeLab.Location = new System.Drawing.Point(325, 45);
            this.questionTypeLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionTypeLab.Name = "questionTypeLab";
            this.questionTypeLab.Size = new System.Drawing.Size(53, 12);
            this.questionTypeLab.TabIndex = 0;
            this.questionTypeLab.Text = "题目类别";
            // 
            // questionTypeCbo
            // 
            this.questionTypeCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questionTypeCbo.FormattingEnabled = true;
            this.questionTypeCbo.Items.AddRange(new object[] {
            "选择题",
            "解答题"});
            this.questionTypeCbo.Location = new System.Drawing.Point(403, 41);
            this.questionTypeCbo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.questionTypeCbo.Name = "questionTypeCbo";
            this.questionTypeCbo.Size = new System.Drawing.Size(92, 20);
            this.questionTypeCbo.TabIndex = 1;
            this.questionTypeCbo.SelectedIndexChanged += new System.EventHandler(this.questionTypeCbo_SelectedIndexChanged);
            // 
            // questionStemLab
            // 
            this.questionStemLab.AutoSize = true;
            this.questionStemLab.Location = new System.Drawing.Point(46, 22);
            this.questionStemLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionStemLab.Name = "questionStemLab";
            this.questionStemLab.Size = new System.Drawing.Size(29, 12);
            this.questionStemLab.TabIndex = 2;
            this.questionStemLab.Text = "题干";
            // 
            // questionStemTxt
            // 
            this.questionStemTxt.Location = new System.Drawing.Point(76, 19);
            this.questionStemTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.questionStemTxt.Name = "questionStemTxt";
            this.questionStemTxt.Size = new System.Drawing.Size(596, 71);
            this.questionStemTxt.TabIndex = 3;
            this.questionStemTxt.Text = "";
            // 
            // AddChoicePanel
            // 
            this.AddChoicePanel.Controls.Add(this.questionAnswerCbo);
            this.AddChoicePanel.Controls.Add(this.questionAnswerLab);
            this.AddChoicePanel.Controls.Add(this.questionOptionDLab);
            this.AddChoicePanel.Controls.Add(this.questionOptionCLab);
            this.AddChoicePanel.Controls.Add(this.questionOptionBLab);
            this.AddChoicePanel.Controls.Add(this.questionOptionALab);
            this.AddChoicePanel.Controls.Add(this.questionOptionDTxt);
            this.AddChoicePanel.Controls.Add(this.questionOptionCTxt);
            this.AddChoicePanel.Controls.Add(this.questionOptionBTxt);
            this.AddChoicePanel.Controls.Add(this.questionOptionATxt);
            this.AddChoicePanel.Controls.Add(this.AddQuestionSubmitBtn);
            this.AddChoicePanel.Controls.Add(this.AddQuestionReset);
            this.AddChoicePanel.Controls.Add(this.questionOptionLab);
            this.AddChoicePanel.Controls.Add(this.questionStemTxt);
            this.AddChoicePanel.Controls.Add(this.questionStemLab);
            this.AddChoicePanel.Location = new System.Drawing.Point(51, 61);
            this.AddChoicePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddChoicePanel.Name = "AddChoicePanel";
            this.AddChoicePanel.Size = new System.Drawing.Size(719, 291);
            this.AddChoicePanel.TabIndex = 4;
            this.AddChoicePanel.Visible = false;
            // 
            // questionAnswerCbo
            // 
            this.questionAnswerCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questionAnswerCbo.FormattingEnabled = true;
            this.questionAnswerCbo.Items.AddRange(new object[] {
            "请选择：",
            "A",
            "B",
            "C",
            "D"});
            this.questionAnswerCbo.Location = new System.Drawing.Point(76, 264);
            this.questionAnswerCbo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.questionAnswerCbo.Name = "questionAnswerCbo";
            this.questionAnswerCbo.Size = new System.Drawing.Size(77, 20);
            this.questionAnswerCbo.TabIndex = 11;
            // 
            // questionAnswerLab
            // 
            this.questionAnswerLab.AutoSize = true;
            this.questionAnswerLab.Location = new System.Drawing.Point(44, 266);
            this.questionAnswerLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionAnswerLab.Name = "questionAnswerLab";
            this.questionAnswerLab.Size = new System.Drawing.Size(29, 12);
            this.questionAnswerLab.TabIndex = 10;
            this.questionAnswerLab.Text = "答案";
            // 
            // questionOptionDLab
            // 
            this.questionOptionDLab.AutoSize = true;
            this.questionOptionDLab.Location = new System.Drawing.Point(74, 220);
            this.questionOptionDLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionOptionDLab.Name = "questionOptionDLab";
            this.questionOptionDLab.Size = new System.Drawing.Size(11, 12);
            this.questionOptionDLab.TabIndex = 9;
            this.questionOptionDLab.Text = "D";
            // 
            // questionOptionCLab
            // 
            this.questionOptionCLab.AutoSize = true;
            this.questionOptionCLab.Location = new System.Drawing.Point(74, 189);
            this.questionOptionCLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionOptionCLab.Name = "questionOptionCLab";
            this.questionOptionCLab.Size = new System.Drawing.Size(11, 12);
            this.questionOptionCLab.TabIndex = 9;
            this.questionOptionCLab.Text = "C";
            // 
            // questionOptionBLab
            // 
            this.questionOptionBLab.AutoSize = true;
            this.questionOptionBLab.Location = new System.Drawing.Point(74, 158);
            this.questionOptionBLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionOptionBLab.Name = "questionOptionBLab";
            this.questionOptionBLab.Size = new System.Drawing.Size(11, 12);
            this.questionOptionBLab.TabIndex = 9;
            this.questionOptionBLab.Text = "B";
            // 
            // questionOptionALab
            // 
            this.questionOptionALab.AutoSize = true;
            this.questionOptionALab.Location = new System.Drawing.Point(74, 126);
            this.questionOptionALab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionOptionALab.Name = "questionOptionALab";
            this.questionOptionALab.Size = new System.Drawing.Size(11, 12);
            this.questionOptionALab.TabIndex = 9;
            this.questionOptionALab.Text = "A";
            // 
            // questionOptionDTxt
            // 
            this.questionOptionDTxt.Location = new System.Drawing.Point(90, 218);
            this.questionOptionDTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.questionOptionDTxt.Name = "questionOptionDTxt";
            this.questionOptionDTxt.Size = new System.Drawing.Size(582, 26);
            this.questionOptionDTxt.TabIndex = 8;
            this.questionOptionDTxt.Text = "";
            // 
            // questionOptionCTxt
            // 
            this.questionOptionCTxt.Location = new System.Drawing.Point(90, 186);
            this.questionOptionCTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.questionOptionCTxt.Name = "questionOptionCTxt";
            this.questionOptionCTxt.Size = new System.Drawing.Size(582, 26);
            this.questionOptionCTxt.TabIndex = 8;
            this.questionOptionCTxt.Text = "";
            // 
            // questionOptionBTxt
            // 
            this.questionOptionBTxt.Location = new System.Drawing.Point(90, 155);
            this.questionOptionBTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.questionOptionBTxt.Name = "questionOptionBTxt";
            this.questionOptionBTxt.Size = new System.Drawing.Size(582, 26);
            this.questionOptionBTxt.TabIndex = 8;
            this.questionOptionBTxt.Text = "";
            // 
            // questionOptionATxt
            // 
            this.questionOptionATxt.Location = new System.Drawing.Point(90, 124);
            this.questionOptionATxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.questionOptionATxt.Name = "questionOptionATxt";
            this.questionOptionATxt.Size = new System.Drawing.Size(582, 26);
            this.questionOptionATxt.TabIndex = 8;
            this.questionOptionATxt.Text = "";
            // 
            // AddQuestionSubmitBtn
            // 
            this.AddQuestionSubmitBtn.Location = new System.Drawing.Point(525, 275);
            this.AddQuestionSubmitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddQuestionSubmitBtn.Name = "AddQuestionSubmitBtn";
            this.AddQuestionSubmitBtn.Size = new System.Drawing.Size(56, 18);
            this.AddQuestionSubmitBtn.TabIndex = 7;
            this.AddQuestionSubmitBtn.Text = "提交";
            this.AddQuestionSubmitBtn.UseVisualStyleBackColor = true;
            this.AddQuestionSubmitBtn.Click += new System.EventHandler(this.AddQuestionSubmitBtn_Click);
            // 
            // AddQuestionReset
            // 
            this.AddQuestionReset.Location = new System.Drawing.Point(606, 275);
            this.AddQuestionReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddQuestionReset.Name = "AddQuestionReset";
            this.AddQuestionReset.Size = new System.Drawing.Size(56, 18);
            this.AddQuestionReset.TabIndex = 6;
            this.AddQuestionReset.Text = "重置";
            this.AddQuestionReset.UseVisualStyleBackColor = true;
            this.AddQuestionReset.Click += new System.EventHandler(this.AddQuestionReset_Click);
            // 
            // questionOptionLab
            // 
            this.questionOptionLab.AutoSize = true;
            this.questionOptionLab.Location = new System.Drawing.Point(46, 114);
            this.questionOptionLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionOptionLab.Name = "questionOptionLab";
            this.questionOptionLab.Size = new System.Drawing.Size(29, 12);
            this.questionOptionLab.TabIndex = 4;
            this.questionOptionLab.Text = "选项";
            // 
            // AddTxtquestionPanel
            // 
            this.AddTxtquestionPanel.Controls.Add(this.questionTxtResetBtn);
            this.AddTxtquestionPanel.Controls.Add(this.questionTxtSubmitBtn);
            this.AddTxtquestionPanel.Controls.Add(this.questionAnswerTxtTxt);
            this.AddTxtquestionPanel.Controls.Add(this.label1);
            this.AddTxtquestionPanel.Controls.Add(this.questionStemTxtTxt);
            this.AddTxtquestionPanel.Controls.Add(this.questionTxtStemLab);
            this.AddTxtquestionPanel.Location = new System.Drawing.Point(51, 61);
            this.AddTxtquestionPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddTxtquestionPanel.Name = "AddTxtquestionPanel";
            this.AddTxtquestionPanel.Size = new System.Drawing.Size(718, 290);
            this.AddTxtquestionPanel.TabIndex = 5;
            this.AddTxtquestionPanel.Visible = false;
            // 
            // questionTxtResetBtn
            // 
            this.questionTxtResetBtn.Location = new System.Drawing.Point(604, 249);
            this.questionTxtResetBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.questionTxtResetBtn.Name = "questionTxtResetBtn";
            this.questionTxtResetBtn.Size = new System.Drawing.Size(56, 18);
            this.questionTxtResetBtn.TabIndex = 5;
            this.questionTxtResetBtn.Text = "重置";
            this.questionTxtResetBtn.UseVisualStyleBackColor = true;
            this.questionTxtResetBtn.Click += new System.EventHandler(this.questionTxtResetBtn_Click);
            // 
            // questionTxtSubmitBtn
            // 
            this.questionTxtSubmitBtn.Location = new System.Drawing.Point(524, 249);
            this.questionTxtSubmitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.questionTxtSubmitBtn.Name = "questionTxtSubmitBtn";
            this.questionTxtSubmitBtn.Size = new System.Drawing.Size(56, 18);
            this.questionTxtSubmitBtn.TabIndex = 4;
            this.questionTxtSubmitBtn.Text = "提交";
            this.questionTxtSubmitBtn.UseVisualStyleBackColor = true;
            this.questionTxtSubmitBtn.Click += new System.EventHandler(this.questionTxtSubmitBtn_Click);
            // 
            // questionAnswerTxtTxt
            // 
            this.questionAnswerTxtTxt.Location = new System.Drawing.Point(102, 150);
            this.questionAnswerTxtTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.questionAnswerTxtTxt.Name = "questionAnswerTxtTxt";
            this.questionAnswerTxtTxt.Size = new System.Drawing.Size(560, 65);
            this.questionAnswerTxtTxt.TabIndex = 3;
            this.questionAnswerTxtTxt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "参考答案";
            // 
            // questionStemTxtTxt
            // 
            this.questionStemTxtTxt.Location = new System.Drawing.Point(102, 20);
            this.questionStemTxtTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.questionStemTxtTxt.Name = "questionStemTxtTxt";
            this.questionStemTxtTxt.Size = new System.Drawing.Size(560, 121);
            this.questionStemTxtTxt.TabIndex = 1;
            this.questionStemTxtTxt.Text = "";
            // 
            // questionTxtStemLab
            // 
            this.questionTxtStemLab.AutoSize = true;
            this.questionTxtStemLab.Location = new System.Drawing.Point(57, 23);
            this.questionTxtStemLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionTxtStemLab.Name = "questionTxtStemLab";
            this.questionTxtStemLab.Size = new System.Drawing.Size(29, 12);
            this.questionTxtStemLab.TabIndex = 0;
            this.questionTxtStemLab.Text = "题干";
            // 
            // AddQuestionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(803, 365);
            this.Controls.Add(this.AddTxtquestionPanel);
            this.Controls.Add(this.AddChoicePanel);
            this.Controls.Add(this.questionTypeCbo);
            this.Controls.Add(this.questionTypeLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "AddQuestionFrm";
            this.Text = "添加题目";
            this.AddChoicePanel.ResumeLayout(false);
            this.AddChoicePanel.PerformLayout();
            this.AddTxtquestionPanel.ResumeLayout(false);
            this.AddTxtquestionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label questionTypeLab;
        public System.Windows.Forms.ComboBox questionTypeCbo;
        public System.Windows.Forms.Label questionStemLab;
        public System.Windows.Forms.RichTextBox questionStemTxt;
        public System.Windows.Forms.Panel AddChoicePanel;
        public System.Windows.Forms.RichTextBox questionOptionDTxt;
        public System.Windows.Forms.RichTextBox questionOptionCTxt;
        public System.Windows.Forms.RichTextBox questionOptionBTxt;
        public System.Windows.Forms.RichTextBox questionOptionATxt;
        public System.Windows.Forms.Button AddQuestionSubmitBtn;
        public System.Windows.Forms.Button AddQuestionReset;
        public System.Windows.Forms.Label questionOptionLab;
        public System.Windows.Forms.Label questionOptionDLab;
        public System.Windows.Forms.Label questionOptionCLab;
        public System.Windows.Forms.Label questionOptionBLab;
        public System.Windows.Forms.Label questionOptionALab;
        public System.Windows.Forms.ComboBox questionAnswerCbo;
        public System.Windows.Forms.Label questionAnswerLab;
        public System.Windows.Forms.Panel AddTxtquestionPanel;
        public System.Windows.Forms.Button questionTxtResetBtn;
        public System.Windows.Forms.Button questionTxtSubmitBtn;
        public System.Windows.Forms.RichTextBox questionAnswerTxtTxt;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox questionStemTxtTxt;
        public System.Windows.Forms.Label questionTxtStemLab;
    }
}