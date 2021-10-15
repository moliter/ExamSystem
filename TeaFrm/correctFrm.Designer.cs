
namespace ExamSystem.TeaFrm
{
    partial class correctFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(correctFrm));
            this.paperNameLab = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.paperNameTxt = new System.Windows.Forms.TextBox();
            this.searchResultLv = new System.Windows.Forms.ListView();
            this.paperId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stuId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paperName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.批改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // paperNameLab
            // 
            this.paperNameLab.AutoSize = true;
            this.paperNameLab.ForeColor = System.Drawing.Color.White;
            this.paperNameLab.Location = new System.Drawing.Point(169, 71);
            this.paperNameLab.Name = "paperNameLab";
            this.paperNameLab.Size = new System.Drawing.Size(82, 15);
            this.paperNameLab.TabIndex = 0;
            this.paperNameLab.Text = "试卷名字：";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(455, 71);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 22);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "搜索";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // paperNameTxt
            // 
            this.paperNameTxt.Location = new System.Drawing.Point(257, 68);
            this.paperNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paperNameTxt.Name = "paperNameTxt";
            this.paperNameTxt.Size = new System.Drawing.Size(179, 25);
            this.paperNameTxt.TabIndex = 3;
            // 
            // searchResultLv
            // 
            this.searchResultLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.paperId,
            this.stuId,
            this.paperName});
            this.searchResultLv.ContextMenuStrip = this.rightClick;
            this.searchResultLv.FullRowSelect = true;
            this.searchResultLv.HideSelection = false;
            this.searchResultLv.Location = new System.Drawing.Point(125, 122);
            this.searchResultLv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchResultLv.MultiSelect = false;
            this.searchResultLv.Name = "searchResultLv";
            this.searchResultLv.Size = new System.Drawing.Size(517, 297);
            this.searchResultLv.TabIndex = 4;
            this.searchResultLv.UseCompatibleStateImageBehavior = false;
            this.searchResultLv.View = System.Windows.Forms.View.Details;
            // 
            // paperId
            // 
            this.paperId.Text = "试卷编号";
            this.paperId.Width = 75;
            // 
            // stuId
            // 
            this.stuId.Text = "学生账号";
            this.stuId.Width = 143;
            // 
            // paperName
            // 
            this.paperName.Text = "试卷名称";
            this.paperName.Width = 248;
            // 
            // rightClick
            // 
            this.rightClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.批改ToolStripMenuItem});
            this.rightClick.Name = "rightClick";
            this.rightClick.Size = new System.Drawing.Size(109, 28);
            // 
            // 批改ToolStripMenuItem
            // 
            this.批改ToolStripMenuItem.Name = "批改ToolStripMenuItem";
            this.批改ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.批改ToolStripMenuItem.Text = "批改";
            this.批改ToolStripMenuItem.Click += new System.EventHandler(this.批改ToolStripMenuItem_Click);
            // 
            // correctFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchResultLv);
            this.Controls.Add(this.paperNameTxt);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.paperNameLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "correctFrm";
            this.Text = "批改试卷";
            this.rightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label paperNameLab;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox paperNameTxt;
        private System.Windows.Forms.ListView searchResultLv;
        private System.Windows.Forms.ContextMenuStrip rightClick;
        private System.Windows.Forms.ToolStripMenuItem 批改ToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader paperId;
        private System.Windows.Forms.ColumnHeader stuId;
        private System.Windows.Forms.ColumnHeader paperName;
    }
}