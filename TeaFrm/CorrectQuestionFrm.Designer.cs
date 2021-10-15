
namespace ExamSystem.TeaFrm
{
    partial class CorrectQuestionFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorrectQuestionFrm));
            this.questionStemLab = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.questionStemTxt = new System.Windows.Forms.RichTextBox();
            this.questionAnswerTxt = new System.Windows.Forms.RichTextBox();
            this.questionAnswerLab = new System.Windows.Forms.Label();
            this.scoreNup = new System.Windows.Forms.NumericUpDown();
            this.scoreLab = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scoreNup)).BeginInit();
            this.SuspendLayout();
            // 
            // questionStemLab
            // 
            this.questionStemLab.AutoSize = true;
            this.questionStemLab.ForeColor = System.Drawing.Color.White;
            this.questionStemLab.Location = new System.Drawing.Point(122, 44);
            this.questionStemLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionStemLab.Name = "questionStemLab";
            this.questionStemLab.Size = new System.Drawing.Size(29, 12);
            this.questionStemLab.TabIndex = 0;
            this.questionStemLab.Text = "题目";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(331, 404);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(56, 21);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "提交";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // questionStemTxt
            // 
            this.questionStemTxt.Location = new System.Drawing.Point(170, 41);
            this.questionStemTxt.Margin = new System.Windows.Forms.Padding(2);
            this.questionStemTxt.Name = "questionStemTxt";
            this.questionStemTxt.Size = new System.Drawing.Size(374, 203);
            this.questionStemTxt.TabIndex = 3;
            this.questionStemTxt.Text = "";
            // 
            // questionAnswerTxt
            // 
            this.questionAnswerTxt.Location = new System.Drawing.Point(172, 267);
            this.questionAnswerTxt.Margin = new System.Windows.Forms.Padding(2);
            this.questionAnswerTxt.Name = "questionAnswerTxt";
            this.questionAnswerTxt.Size = new System.Drawing.Size(372, 102);
            this.questionAnswerTxt.TabIndex = 4;
            this.questionAnswerTxt.Text = "";
            // 
            // questionAnswerLab
            // 
            this.questionAnswerLab.AutoSize = true;
            this.questionAnswerLab.ForeColor = System.Drawing.Color.White;
            this.questionAnswerLab.Location = new System.Drawing.Point(107, 269);
            this.questionAnswerLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionAnswerLab.Name = "questionAnswerLab";
            this.questionAnswerLab.Size = new System.Drawing.Size(53, 12);
            this.questionAnswerLab.TabIndex = 5;
            this.questionAnswerLab.Text = "题目答案";
            // 
            // scoreNup
            // 
            this.scoreNup.Location = new System.Drawing.Point(224, 404);
            this.scoreNup.Margin = new System.Windows.Forms.Padding(2);
            this.scoreNup.Name = "scoreNup";
            this.scoreNup.Size = new System.Drawing.Size(90, 21);
            this.scoreNup.TabIndex = 6;
            // 
            // scoreLab
            // 
            this.scoreLab.AutoSize = true;
            this.scoreLab.ForeColor = System.Drawing.Color.White;
            this.scoreLab.Location = new System.Drawing.Point(168, 406);
            this.scoreLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreLab.Name = "scoreLab";
            this.scoreLab.Size = new System.Drawing.Size(29, 12);
            this.scoreLab.TabIndex = 7;
            this.scoreLab.Text = "分数";
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(454, 406);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(56, 19);
            this.nextBtn.TabIndex = 8;
            this.nextBtn.Text = "下一题";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // CorrectQuestionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 457);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.scoreLab);
            this.Controls.Add(this.scoreNup);
            this.Controls.Add(this.questionAnswerLab);
            this.Controls.Add(this.questionAnswerTxt);
            this.Controls.Add(this.questionStemTxt);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.questionStemLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CorrectQuestionFrm";
            this.Text = "批改试卷";
            ((System.ComponentModel.ISupportInitialize)(this.scoreNup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionStemLab;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.RichTextBox questionStemTxt;
        private System.Windows.Forms.RichTextBox questionAnswerTxt;
        private System.Windows.Forms.Label questionAnswerLab;
        private System.Windows.Forms.NumericUpDown scoreNup;
        private System.Windows.Forms.Label scoreLab;
        private System.Windows.Forms.Button nextBtn;
    }
}