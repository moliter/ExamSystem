
namespace ExamSystem.TeaFrm
{
    partial class TeaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeaFrm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.QuestionMkBtn = new System.Windows.Forms.ToolStripButton();
            this.questionModifyBtn = new System.Windows.Forms.ToolStripButton();
            this.PaperMkBtn = new System.Windows.Forms.ToolStripButton();
            this.correctPaperBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuestionMkBtn,
            this.questionModifyBtn,
            this.PaperMkBtn,
            this.correctPaperBtn});
            this.toolStrip1.Location = new System.Drawing.Point(8, 39);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // QuestionMkBtn
            // 
            this.QuestionMkBtn.Image = ((System.Drawing.Image)(resources.GetObject("QuestionMkBtn.Image")));
            this.QuestionMkBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QuestionMkBtn.Name = "QuestionMkBtn";
            this.QuestionMkBtn.Size = new System.Drawing.Size(93, 28);
            this.QuestionMkBtn.Text = "题目制作";
            this.QuestionMkBtn.Click += new System.EventHandler(this.QuestionMkBtn_Click);
            // 
            // questionModifyBtn
            // 
            this.questionModifyBtn.Image = ((System.Drawing.Image)(resources.GetObject("questionModifyBtn.Image")));
            this.questionModifyBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.questionModifyBtn.Name = "questionModifyBtn";
            this.questionModifyBtn.Size = new System.Drawing.Size(93, 28);
            this.questionModifyBtn.Text = "题目修改";
            this.questionModifyBtn.Click += new System.EventHandler(this.questionModifyBtn_Click);
            // 
            // PaperMkBtn
            // 
            this.PaperMkBtn.Image = ((System.Drawing.Image)(resources.GetObject("PaperMkBtn.Image")));
            this.PaperMkBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaperMkBtn.Name = "PaperMkBtn";
            this.PaperMkBtn.Size = new System.Drawing.Size(93, 28);
            this.PaperMkBtn.Text = "试卷制作";
            this.PaperMkBtn.Click += new System.EventHandler(this.PaperMkBtn_Click);
            // 
            // correctPaperBtn
            // 
            this.correctPaperBtn.Image = ((System.Drawing.Image)(resources.GetObject("correctPaperBtn.Image")));
            this.correctPaperBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.correctPaperBtn.Name = "correctPaperBtn";
            this.correctPaperBtn.Size = new System.Drawing.Size(93, 28);
            this.correctPaperBtn.Text = "批改试卷";
            this.correctPaperBtn.Click += new System.EventHandler(this.correctPaperBtn_Click);
            // 
            // TeaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "TeaFrm";
            this.Text = "教师";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton QuestionMkBtn;
        private System.Windows.Forms.ToolStripButton PaperMkBtn;
        private System.Windows.Forms.ToolStripButton questionModifyBtn;
        private System.Windows.Forms.ToolStripButton correctPaperBtn;
    }
}