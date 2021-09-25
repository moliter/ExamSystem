
namespace ExamSystem.UserManage
{
    partial class SearchUserFrm
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
            this.typeSeacrhCbo = new System.Windows.Forms.ComboBox();
            this.searchInputTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchList = new System.Windows.Forms.ListView();
            this.resultNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightContextClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.rightContextClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeSeacrhCbo
            // 
            this.typeSeacrhCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeSeacrhCbo.FormattingEnabled = true;
            this.typeSeacrhCbo.Items.AddRange(new object[] {
            "名字：",
            "账号：",
            "电话号码："});
            this.typeSeacrhCbo.Location = new System.Drawing.Point(57, 30);
            this.typeSeacrhCbo.Name = "typeSeacrhCbo";
            this.typeSeacrhCbo.Size = new System.Drawing.Size(95, 23);
            this.typeSeacrhCbo.TabIndex = 0;
            // 
            // searchInputTxt
            // 
            this.searchInputTxt.Location = new System.Drawing.Point(158, 30);
            this.searchInputTxt.Name = "searchInputTxt";
            this.searchInputTxt.Size = new System.Drawing.Size(191, 25);
            this.searchInputTxt.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(355, 32);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(76, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "搜索";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchList
            // 
            this.searchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.resultNum,
            this.resultName,
            this.resultTel,
            this.searchRole,
            this.resultClass});
            this.searchList.ContextMenuStrip = this.rightContextClick;
            this.searchList.FullRowSelect = true;
            this.searchList.HideSelection = false;
            this.searchList.Location = new System.Drawing.Point(57, 61);
            this.searchList.MultiSelect = false;
            this.searchList.Name = "searchList";
            this.searchList.Size = new System.Drawing.Size(660, 281);
            this.searchList.TabIndex = 3;
            this.searchList.UseCompatibleStateImageBehavior = false;
            this.searchList.View = System.Windows.Forms.View.Details;
            // 
            // resultNum
            // 
            this.resultNum.Text = "账号";
            this.resultNum.Width = 80;
            // 
            // resultName
            // 
            this.resultName.Text = "名字";
            this.resultName.Width = 80;
            // 
            // resultTel
            // 
            this.resultTel.Text = "电话";
            this.resultTel.Width = 150;
            // 
            // searchRole
            // 
            this.searchRole.Text = "身份";
            this.searchRole.Width = 100;
            // 
            // resultClass
            // 
            this.resultClass.Text = "班级";
            this.resultClass.Width = 120;
            // 
            // rightContextClick
            // 
            this.rightContextClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightContextClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改ToolStripMenuItem,
            this.deleteUserBtn});
            this.rightContextClick.Name = "rightContextClick";
            this.rightContextClick.Size = new System.Drawing.Size(210, 79);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.修改ToolStripMenuItem.Text = "修改";
            // 
            // deleteUserBtn
            // 
            this.deleteUserBtn.Name = "deleteUserBtn";
            this.deleteUserBtn.Size = new System.Drawing.Size(209, 24);
            this.deleteUserBtn.Text = "删除";
            this.deleteUserBtn.Click += new System.EventHandler(this.deleteUserBtn_Click);
            // 
            // SearchUserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 354);
            this.Controls.Add(this.searchList);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchInputTxt);
            this.Controls.Add(this.typeSeacrhCbo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SearchUserFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找用户";
            this.rightContextClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeSeacrhCbo;
        private System.Windows.Forms.TextBox searchInputTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListView searchList;
        private System.Windows.Forms.ColumnHeader resultName;
        private System.Windows.Forms.ColumnHeader resultNum;
        private System.Windows.Forms.ColumnHeader resultTel;
        private System.Windows.Forms.ColumnHeader searchRole;
        private System.Windows.Forms.ColumnHeader resultClass;
        private System.Windows.Forms.ContextMenuStrip rightContextClick;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserBtn;
    }
}