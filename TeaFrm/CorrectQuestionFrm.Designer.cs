
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
            this.questionStemLab.BackColor = System.Drawing.Color.Transparent;
            this.questionStemLab.ForeColor = System.Drawing.Color.White;
            this.questionStemLab.Location = new System.Drawing.Point(57, 55);
            this.questionStemLab.Name = "questionStemLab";
            this.questionStemLab.Size = new System.Drawing.Size(37, 15);
            this.questionStemLab.TabIndex = 0;
            this.questionStemLab.Text = "题目";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(335, 494);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 26);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "提交";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // questionStemTxt
            // 
            this.questionStemTxt.Location = new System.Drawing.Point(108, 55);
            this.questionStemTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.questionStemTxt.Name = "questionStemTxt";
            this.questionStemTxt.Size = new System.Drawing.Size(497, 253);
            this.questionStemTxt.TabIndex = 3;
            this.questionStemTxt.Text = "";
            // 
            // questionAnswerTxt
            // 
            this.questionAnswerTxt.Location = new System.Drawing.Point(110, 336);
            this.questionAnswerTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.questionAnswerTxt.Name = "questionAnswerTxt";
            this.questionAnswerTxt.Size = new System.Drawing.Size(495, 126);
            this.questionAnswerTxt.TabIndex = 4;
            this.questionAnswerTxt.Text = "";
            // 
            // questionAnswerLab
            // 
            this.questionAnswerLab.AutoSize = true;
            this.questionAnswerLab.BackColor = System.Drawing.Color.Transparent;
            this.questionAnswerLab.ForeColor = System.Drawing.Color.White;
            this.questionAnswerLab.Location = new System.Drawing.Point(37, 336);
            this.questionAnswerLab.Name = "questionAnswerLab";
            this.questionAnswerLab.Size = new System.Drawing.Size(67, 15);
            this.questionAnswerLab.TabIndex = 5;
            this.questionAnswerLab.Text = "题目答案";
            // 
            // scoreNup
            // 
            this.scoreNup.Location = new System.Drawing.Point(193, 494);
            this.scoreNup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scoreNup.Name = "scoreNup";
            this.scoreNup.Size = new System.Drawing.Size(120, 25);
            this.scoreNup.TabIndex = 6;
            // 
            // scoreLab
            // 
            this.scoreLab.AutoSize = true;
            this.scoreLab.ForeColor = System.Drawing.Color.White;
            this.scoreLab.Location = new System.Drawing.Point(118, 497);
            this.scoreLab.Name = "scoreLab";
            this.scoreLab.Size = new System.Drawing.Size(37, 15);
            this.scoreLab.TabIndex = 7;
            this.scoreLab.Text = "分数";
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(499, 497);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 24);
            this.nextBtn.TabIndex = 8;
            this.nextBtn.Text = "下一题";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // CorrectQuestionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 537);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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