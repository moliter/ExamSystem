
namespace ExamSystem.StuFrm
{
    partial class StuExamFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuExamFrm));
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.questionStemTxt = new System.Windows.Forms.RichTextBox();
            this.choiceC = new System.Windows.Forms.RadioButton();
            this.choiceA = new System.Windows.Forms.RadioButton();
            this.choiceD = new System.Windows.Forms.RadioButton();
            this.choiceB = new System.Windows.Forms.RadioButton();
            this.ChoicePanel = new System.Windows.Forms.Panel();
            this.choiceCTxt = new System.Windows.Forms.RichTextBox();
            this.choiceDTxt = new System.Windows.Forms.RichTextBox();
            this.choiceBTxt = new System.Windows.Forms.RichTextBox();
            this.choiceATxt = new System.Windows.Forms.RichTextBox();
            this.questionTxtRtxt = new System.Windows.Forms.RichTextBox();
            this.NextQuestionBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.correctlab = new System.Windows.Forms.Label();
            this.timeLab = new System.Windows.Forms.Label();
            this.ChoicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.ForeColor = System.Drawing.Color.Blue;
            this.exitBtn.Location = new System.Drawing.Point(1183, 68);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(85, 38);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "退出";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "题目";
            // 
            // questionStemTxt
            // 
            this.questionStemTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.questionStemTxt.Location = new System.Drawing.Point(195, 68);
            this.questionStemTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.questionStemTxt.Name = "questionStemTxt";
            this.questionStemTxt.Size = new System.Drawing.Size(948, 343);
            this.questionStemTxt.TabIndex = 2;
            this.questionStemTxt.Text = "";
            // 
            // choiceC
            // 
            this.choiceC.AutoSize = true;
            this.choiceC.ForeColor = System.Drawing.Color.White;
            this.choiceC.Location = new System.Drawing.Point(17, 88);
            this.choiceC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.choiceC.Name = "choiceC";
            this.choiceC.Size = new System.Drawing.Size(36, 19);
            this.choiceC.TabIndex = 3;
            this.choiceC.TabStop = true;
            this.choiceC.Text = "C";
            this.choiceC.UseVisualStyleBackColor = true;
            // 
            // choiceA
            // 
            this.choiceA.AutoSize = true;
            this.choiceA.ForeColor = System.Drawing.Color.White;
            this.choiceA.Location = new System.Drawing.Point(17, 28);
            this.choiceA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.choiceA.Name = "choiceA";
            this.choiceA.Size = new System.Drawing.Size(36, 19);
            this.choiceA.TabIndex = 4;
            this.choiceA.TabStop = true;
            this.choiceA.Text = "A";
            this.choiceA.UseVisualStyleBackColor = true;
            // 
            // choiceD
            // 
            this.choiceD.AutoSize = true;
            this.choiceD.ForeColor = System.Drawing.Color.White;
            this.choiceD.Location = new System.Drawing.Point(17, 118);
            this.choiceD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.choiceD.Name = "choiceD";
            this.choiceD.Size = new System.Drawing.Size(36, 19);
            this.choiceD.TabIndex = 5;
            this.choiceD.TabStop = true;
            this.choiceD.Text = "D";
            this.choiceD.UseVisualStyleBackColor = true;
            // 
            // choiceB
            // 
            this.choiceB.AutoSize = true;
            this.choiceB.ForeColor = System.Drawing.Color.White;
            this.choiceB.Location = new System.Drawing.Point(17, 58);
            this.choiceB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.choiceB.Name = "choiceB";
            this.choiceB.Size = new System.Drawing.Size(36, 19);
            this.choiceB.TabIndex = 6;
            this.choiceB.TabStop = true;
            this.choiceB.Text = "B";
            this.choiceB.UseVisualStyleBackColor = true;
            // 
            // ChoicePanel
            // 
            this.ChoicePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ChoicePanel.Controls.Add(this.choiceCTxt);
            this.ChoicePanel.Controls.Add(this.choiceDTxt);
            this.ChoicePanel.Controls.Add(this.choiceBTxt);
            this.ChoicePanel.Controls.Add(this.choiceATxt);
            this.ChoicePanel.Controls.Add(this.choiceA);
            this.ChoicePanel.Controls.Add(this.choiceB);
            this.ChoicePanel.Controls.Add(this.choiceC);
            this.ChoicePanel.Controls.Add(this.choiceD);
            this.ChoicePanel.Location = new System.Drawing.Point(195, 426);
            this.ChoicePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChoicePanel.Name = "ChoicePanel";
            this.ChoicePanel.Size = new System.Drawing.Size(409, 168);
            this.ChoicePanel.TabIndex = 7;
            this.ChoicePanel.Visible = false;
            // 
            // choiceCTxt
            // 
            this.choiceCTxt.Location = new System.Drawing.Point(53, 85);
            this.choiceCTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.choiceCTxt.Multiline = false;
            this.choiceCTxt.Name = "choiceCTxt";
            this.choiceCTxt.Size = new System.Drawing.Size(321, 29);
            this.choiceCTxt.TabIndex = 9;
            this.choiceCTxt.Text = "";
            // 
            // choiceDTxt
            // 
            this.choiceDTxt.Location = new System.Drawing.Point(53, 114);
            this.choiceDTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.choiceDTxt.Multiline = false;
            this.choiceDTxt.Name = "choiceDTxt";
            this.choiceDTxt.Size = new System.Drawing.Size(321, 29);
            this.choiceDTxt.TabIndex = 9;
            this.choiceDTxt.Text = "";
            // 
            // choiceBTxt
            // 
            this.choiceBTxt.Location = new System.Drawing.Point(53, 56);
            this.choiceBTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.choiceBTxt.Multiline = false;
            this.choiceBTxt.Name = "choiceBTxt";
            this.choiceBTxt.Size = new System.Drawing.Size(321, 29);
            this.choiceBTxt.TabIndex = 9;
            this.choiceBTxt.Text = "";
            // 
            // choiceATxt
            // 
            this.choiceATxt.Location = new System.Drawing.Point(53, 28);
            this.choiceATxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.choiceATxt.Multiline = false;
            this.choiceATxt.Name = "choiceATxt";
            this.choiceATxt.Size = new System.Drawing.Size(321, 29);
            this.choiceATxt.TabIndex = 9;
            this.choiceATxt.Text = "";
            // 
            // questionTxtRtxt
            // 
            this.questionTxtRtxt.Location = new System.Drawing.Point(621, 438);
            this.questionTxtRtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.questionTxtRtxt.Name = "questionTxtRtxt";
            this.questionTxtRtxt.Size = new System.Drawing.Size(519, 142);
            this.questionTxtRtxt.TabIndex = 8;
            this.questionTxtRtxt.Text = "";
            this.questionTxtRtxt.Visible = false;
            // 
            // NextQuestionBtn
            // 
            this.NextQuestionBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NextQuestionBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NextQuestionBtn.Location = new System.Drawing.Point(1183, 489);
            this.NextQuestionBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NextQuestionBtn.Name = "NextQuestionBtn";
            this.NextQuestionBtn.Size = new System.Drawing.Size(85, 32);
            this.NextQuestionBtn.TabIndex = 8;
            this.NextQuestionBtn.Text = "下一题";
            this.NextQuestionBtn.UseVisualStyleBackColor = true;
            this.NextQuestionBtn.Click += new System.EventHandler(this.NextQuestionBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.ForeColor = System.Drawing.Color.Blue;
            this.submitBtn.Location = new System.Drawing.Point(1184, 266);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(85, 38);
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "提交";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // correctlab
            // 
            this.correctlab.AutoSize = true;
            this.correctlab.Font = new System.Drawing.Font("宋体", 36.30252F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.correctlab.ForeColor = System.Drawing.Color.White;
            this.correctlab.Location = new System.Drawing.Point(29, 68);
            this.correctlab.Name = "correctlab";
            this.correctlab.Size = new System.Drawing.Size(149, 61);
            this.correctlab.TabIndex = 11;
            this.correctlab.Text = "答案";
            this.correctlab.Visible = false;
            // 
            // timeLab
            // 
            this.timeLab.AutoSize = true;
            this.timeLab.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLab.Location = new System.Drawing.Point(2, 171);
            this.timeLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLab.Name = "timeLab";
            this.timeLab.Size = new System.Drawing.Size(177, 40);
            this.timeLab.TabIndex = 12;
            this.timeLab.Text = "00:00:00";
            // 
            // StuExamFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 656);
            this.Controls.Add(this.timeLab);
            this.Controls.Add(this.questionTxtRtxt);
            this.Controls.Add(this.correctlab);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.NextQuestionBtn);
            this.Controls.Add(this.ChoicePanel);
            this.Controls.Add(this.questionStemTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StuExamFrm";
            this.Text = "学生";
            this.TopMost = true;
            this.ChoicePanel.ResumeLayout(false);
            this.ChoicePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox questionStemTxt;
        private System.Windows.Forms.RadioButton choiceC;
        private System.Windows.Forms.RadioButton choiceA;
        private System.Windows.Forms.RadioButton choiceD;
        private System.Windows.Forms.RadioButton choiceB;
        private System.Windows.Forms.Panel ChoicePanel;
        private System.Windows.Forms.Button NextQuestionBtn;
        private System.Windows.Forms.RichTextBox questionTxtRtxt;
        private System.Windows.Forms.RichTextBox choiceCTxt;
        private System.Windows.Forms.RichTextBox choiceDTxt;
        private System.Windows.Forms.RichTextBox choiceBTxt;
        private System.Windows.Forms.RichTextBox choiceATxt;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label correctlab;
        private System.Windows.Forms.Label timeLab;
    }
}