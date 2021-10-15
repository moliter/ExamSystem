
namespace ExamSystem.StuFrm
{
    partial class StuLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuLogin));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.paperLv = new System.Windows.Forms.ListView();
            this.paperNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paperName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightclick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.joinExamBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.myExamPanel = new System.Windows.Forms.Panel();
            this.scoreLv = new System.Windows.Forms.ListView();
            this.examName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.examScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.rightclick.SuspendLayout();
            this.myExamPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(8, 39);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 24);
            this.toolStripButton1.Text = "我的考试";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(73, 24);
            this.toolStripButton2.Text = "我的信息";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(73, 24);
            this.toolStripButton3.Text = "我的成绩";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // paperLv
            // 
            this.paperLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.paperNum,
            this.paperName});
            this.paperLv.ContextMenuStrip = this.rightclick;
            this.paperLv.FullRowSelect = true;
            this.paperLv.HideSelection = false;
            this.paperLv.Location = new System.Drawing.Point(0, 2);
            this.paperLv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paperLv.MultiSelect = false;
            this.paperLv.Name = "paperLv";
            this.paperLv.Size = new System.Drawing.Size(359, 366);
            this.paperLv.TabIndex = 0;
            this.paperLv.UseCompatibleStateImageBehavior = false;
            this.paperLv.View = System.Windows.Forms.View.Details;
            // 
            // paperNum
            // 
            this.paperNum.Text = "考试编号";
            this.paperNum.Width = 83;
            // 
            // paperName
            // 
            this.paperName.Text = "考试名字";
            this.paperName.Width = 262;
            // 
            // rightclick
            // 
            this.rightclick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightclick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.joinExamBtn});
            this.rightclick.Name = "rightclick";
            this.rightclick.Size = new System.Drawing.Size(139, 28);
            // 
            // joinExamBtn
            // 
            this.joinExamBtn.Name = "joinExamBtn";
            this.joinExamBtn.Size = new System.Drawing.Size(138, 24);
            this.joinExamBtn.Text = "参加考试";
            this.joinExamBtn.Click += new System.EventHandler(this.joinExamBtn_Click);
            // 
            // myExamPanel
            // 
            this.myExamPanel.Controls.Add(this.paperLv);
            this.myExamPanel.Location = new System.Drawing.Point(11, 99);
            this.myExamPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myExamPanel.Name = "myExamPanel";
            this.myExamPanel.Size = new System.Drawing.Size(361, 351);
            this.myExamPanel.TabIndex = 1;
            this.myExamPanel.Visible = false;
            // 
            // scoreLv
            // 
            this.scoreLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.examName,
            this.examScore});
            this.scoreLv.HideSelection = false;
            this.scoreLv.Location = new System.Drawing.Point(397, 101);
            this.scoreLv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scoreLv.Name = "scoreLv";
            this.scoreLv.Size = new System.Drawing.Size(369, 348);
            this.scoreLv.TabIndex = 2;
            this.scoreLv.UseCompatibleStateImageBehavior = false;
            this.scoreLv.View = System.Windows.Forms.View.Details;
            this.scoreLv.Visible = false;
            // 
            // examName
            // 
            this.examName.Text = "考试名称";
            this.examName.Width = 166;
            // 
            // examScore
            // 
            this.examScore.Text = "考试分数";
            this.examScore.Width = 115;
            // 
            // StuLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.scoreLv);
            this.Controls.Add(this.myExamPanel);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StuLogin";
            this.Text = "学生";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.rightclick.ResumeLayout(false);
            this.myExamPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ListView paperLv;
        private System.Windows.Forms.ColumnHeader paperNum;
        private System.Windows.Forms.ColumnHeader paperName;
        private System.Windows.Forms.Panel myExamPanel;
        private System.Windows.Forms.ContextMenuStrip rightclick;
        private System.Windows.Forms.ToolStripMenuItem joinExamBtn;
        private System.Windows.Forms.ListView scoreLv;
        private System.Windows.Forms.ColumnHeader examName;
        private System.Windows.Forms.ColumnHeader examScore;
    }
}