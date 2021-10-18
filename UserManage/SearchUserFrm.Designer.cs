
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchUserFrm));
            this.typeSeacrhCbo = new System.Windows.Forms.ComboBox();
            this.searchInputTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchList = new System.Windows.Forms.ListView();
            this.resultNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultPwd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightContextClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeUserBtn = new System.Windows.Forms.ToolStripMenuItem();
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
            this.typeSeacrhCbo.Location = new System.Drawing.Point(57, 64);
            this.typeSeacrhCbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeSeacrhCbo.Name = "typeSeacrhCbo";
            this.typeSeacrhCbo.Size = new System.Drawing.Size(95, 23);
            this.typeSeacrhCbo.TabIndex = 0;
            this.typeSeacrhCbo.SelectedIndex = 0;
            // 
            // searchInputTxt
            // 
            this.searchInputTxt.Location = new System.Drawing.Point(159, 62);
            this.searchInputTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchInputTxt.Name = "searchInputTxt";
            this.searchInputTxt.Size = new System.Drawing.Size(191, 25);
            this.searchInputTxt.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(356, 61);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(76, 22);
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
            this.resultPwd,
            this.resultGender,
            this.resultTel,
            this.resultClass,
            this.searchRole});
            this.searchList.ContextMenuStrip = this.rightContextClick;
            this.searchList.FullRowSelect = true;
            this.searchList.HideSelection = false;
            this.searchList.Location = new System.Drawing.Point(11, 109);
            this.searchList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchList.MultiSelect = false;
            this.searchList.Name = "searchList";
            this.searchList.Size = new System.Drawing.Size(689, 256);
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
            this.resultName.Width = 52;
            // 
            // resultPwd
            // 
            this.resultPwd.Text = "密码";
            // 
            // resultGender
            // 
            this.resultGender.Text = "性别";
            this.resultGender.Width = 50;
            // 
            // resultTel
            // 
            this.resultTel.Text = "电话";
            this.resultTel.Width = 101;
            // 
            // resultClass
            // 
            this.resultClass.Text = "班级";
            this.resultClass.Width = 99;
            // 
            // searchRole
            // 
            this.searchRole.Text = "身份";
            this.searchRole.Width = 50;
            // 
            // rightContextClick
            // 
            this.rightContextClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightContextClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUserBtn,
            this.deleteUserBtn});
            this.rightContextClick.Name = "rightContextClick";
            this.rightContextClick.Size = new System.Drawing.Size(109, 52);
            // 
            // changeUserBtn
            // 
            this.changeUserBtn.Name = "changeUserBtn";
            this.changeUserBtn.Size = new System.Drawing.Size(108, 24);
            this.changeUserBtn.Text = "修改";
            this.changeUserBtn.Click += new System.EventHandler(this.changeUserBtn_Click);
            // 
            // deleteUserBtn
            // 
            this.deleteUserBtn.Name = "deleteUserBtn";
            this.deleteUserBtn.Size = new System.Drawing.Size(108, 24);
            this.deleteUserBtn.Text = "删除";
            this.deleteUserBtn.Click += new System.EventHandler(this.deleteUserBtn_Click);
            // 
            // SearchUserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 426);
            this.Controls.Add(this.searchList);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchInputTxt);
            this.Controls.Add(this.typeSeacrhCbo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "SearchUserFrm";
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
        private System.Windows.Forms.ToolStripMenuItem changeUserBtn;
        private System.Windows.Forms.ToolStripMenuItem deleteUserBtn;
        private System.Windows.Forms.ColumnHeader resultPwd;
        private System.Windows.Forms.ColumnHeader resultGender;
    }
}