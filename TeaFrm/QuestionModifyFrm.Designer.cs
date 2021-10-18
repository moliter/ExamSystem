
namespace ExamSystem.TeaFrm
{
    partial class QuestionModifyFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionModifyFrm));
            this.searchKeyTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.questionChoiceLv = new System.Windows.Forms.ListView();
            this.questionChoiceId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionChoiceType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionChoiceStem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionChoiceA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionChoiceB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionChoiceC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionChoiceD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionChoiceAnswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightClickCms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyClickBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.delClickBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTypeCbo = new System.Windows.Forms.ComboBox();
            this.questionTxtLv = new System.Windows.Forms.ListView();
            this.questionTxtId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionTxtStem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionTxtAnswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionChoiceLab = new System.Windows.Forms.Label();
            this.questionTxtLab = new System.Windows.Forms.Label();
            this.rightClickCms.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchKeyTxt
            // 
            this.searchKeyTxt.Location = new System.Drawing.Point(255, 65);
            this.searchKeyTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchKeyTxt.Name = "searchKeyTxt";
            this.searchKeyTxt.Size = new System.Drawing.Size(337, 25);
            this.searchKeyTxt.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.ForeColor = System.Drawing.Color.Red;
            this.searchBtn.Location = new System.Drawing.Point(613, 56);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 42);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "搜索";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // questionChoiceLv
            // 
            this.questionChoiceLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.questionChoiceId,
            this.questionChoiceType,
            this.questionChoiceStem,
            this.questionChoiceA,
            this.questionChoiceB,
            this.questionChoiceC,
            this.questionChoiceD,
            this.questionChoiceAnswer});
            this.questionChoiceLv.ContextMenuStrip = this.rightClickCms;
            this.questionChoiceLv.FullRowSelect = true;
            this.questionChoiceLv.HideSelection = false;
            this.questionChoiceLv.Location = new System.Drawing.Point(25, 122);
            this.questionChoiceLv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.questionChoiceLv.MultiSelect = false;
            this.questionChoiceLv.Name = "questionChoiceLv";
            this.questionChoiceLv.Size = new System.Drawing.Size(704, 162);
            this.questionChoiceLv.TabIndex = 3;
            this.questionChoiceLv.UseCompatibleStateImageBehavior = false;
            this.questionChoiceLv.View = System.Windows.Forms.View.Details;
            // 
            // questionChoiceId
            // 
            this.questionChoiceId.Text = "题库编号";
            this.questionChoiceId.Width = 80;
            // 
            // questionChoiceType
            // 
            this.questionChoiceType.Text = "题目类型";
            this.questionChoiceType.Width = 76;
            // 
            // questionChoiceStem
            // 
            this.questionChoiceStem.Text = "题干";
            this.questionChoiceStem.Width = 40;
            // 
            // questionChoiceA
            // 
            this.questionChoiceA.Text = "选择A";
            // 
            // questionChoiceB
            // 
            this.questionChoiceB.Text = "选择B";
            // 
            // questionChoiceC
            // 
            this.questionChoiceC.Text = "选择C";
            // 
            // questionChoiceD
            // 
            this.questionChoiceD.Text = "选项D";
            // 
            // questionChoiceAnswer
            // 
            this.questionChoiceAnswer.Text = "题目答案";
            this.questionChoiceAnswer.Width = 77;
            // 
            // rightClickCms
            // 
            this.rightClickCms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightClickCms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBtn,
            this.modifyClickBtn,
            this.delClickBtn});
            this.rightClickCms.Name = "rightClickCms";
            this.rightClickCms.Size = new System.Drawing.Size(139, 76);
            // 
            // viewBtn
            // 
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(138, 24);
            this.viewBtn.Text = "查看详情";
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // modifyClickBtn
            // 
            this.modifyClickBtn.Name = "modifyClickBtn";
            this.modifyClickBtn.Size = new System.Drawing.Size(138, 24);
            this.modifyClickBtn.Text = "修改";
            this.modifyClickBtn.Click += new System.EventHandler(this.modifyClickBtn_Click);
            // 
            // delClickBtn
            // 
            this.delClickBtn.Name = "delClickBtn";
            this.delClickBtn.Size = new System.Drawing.Size(138, 24);
            this.delClickBtn.Text = "删除";
            this.delClickBtn.Click += new System.EventHandler(this.delClickBtn_Click);
            // 
            // searchTypeCbo
            // 
            this.searchTypeCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchTypeCbo.FormattingEnabled = true;
            this.searchTypeCbo.Items.AddRange(new object[] {
            "题干：",
            "题库编号：",
            "答案："});
            this.searchTypeCbo.Location = new System.Drawing.Point(169, 66);
            this.searchTypeCbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTypeCbo.Name = "searchTypeCbo";
            this.searchTypeCbo.Size = new System.Drawing.Size(79, 23);
            this.searchTypeCbo.TabIndex = 5;
            this.searchTypeCbo.SelectedIndex = 0;
            // 
            // questionTxtLv
            // 
            this.questionTxtLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.questionTxtId,
            this.questionType,
            this.questionTxtStem,
            this.questionTxtAnswer});
            this.questionTxtLv.ContextMenuStrip = this.rightClickCms;
            this.questionTxtLv.FullRowSelect = true;
            this.questionTxtLv.HideSelection = false;
            this.questionTxtLv.Location = new System.Drawing.Point(25, 325);
            this.questionTxtLv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.questionTxtLv.MultiSelect = false;
            this.questionTxtLv.Name = "questionTxtLv";
            this.questionTxtLv.Size = new System.Drawing.Size(704, 153);
            this.questionTxtLv.TabIndex = 3;
            this.questionTxtLv.UseCompatibleStateImageBehavior = false;
            this.questionTxtLv.View = System.Windows.Forms.View.Details;
            // 
            // questionTxtId
            // 
            this.questionTxtId.Text = "题库编号";
            this.questionTxtId.Width = 73;
            // 
            // questionType
            // 
            this.questionType.Text = "题库类型";
            this.questionType.Width = 73;
            // 
            // questionTxtStem
            // 
            this.questionTxtStem.Text = "题干";
            this.questionTxtStem.Width = 476;
            // 
            // questionTxtAnswer
            // 
            this.questionTxtAnswer.Text = "题目答案";
            this.questionTxtAnswer.Width = 77;
            // 
            // questionChoiceLab
            // 
            this.questionChoiceLab.AutoSize = true;
            this.questionChoiceLab.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.questionChoiceLab.Location = new System.Drawing.Point(68, 95);
            this.questionChoiceLab.Name = "questionChoiceLab";
            this.questionChoiceLab.Size = new System.Drawing.Size(67, 15);
            this.questionChoiceLab.TabIndex = 6;
            this.questionChoiceLab.Text = "客观题：";
            // 
            // questionTxtLab
            // 
            this.questionTxtLab.AutoSize = true;
            this.questionTxtLab.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.questionTxtLab.Location = new System.Drawing.Point(68, 308);
            this.questionTxtLab.Name = "questionTxtLab";
            this.questionTxtLab.Size = new System.Drawing.Size(67, 15);
            this.questionTxtLab.TabIndex = 6;
            this.questionTxtLab.Text = "主观题：";
            // 
            // QuestionModifyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(757, 516);
            this.Controls.Add(this.questionTxtLab);
            this.Controls.Add(this.questionChoiceLab);
            this.Controls.Add(this.searchTypeCbo);
            this.Controls.Add(this.questionTxtLv);
            this.Controls.Add(this.questionChoiceLv);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchKeyTxt);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "QuestionModifyFrm";
            this.Text = "题目修改";
            this.rightClickCms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchKeyTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListView questionChoiceLv;
        private System.Windows.Forms.ContextMenuStrip rightClickCms;
        private System.Windows.Forms.ComboBox searchTypeCbo;
        private System.Windows.Forms.ListView questionTxtLv;
        private System.Windows.Forms.Label questionChoiceLab;
        private System.Windows.Forms.Label questionTxtLab;
        private System.Windows.Forms.ToolStripMenuItem modifyClickBtn;
        private System.Windows.Forms.ToolStripMenuItem delClickBtn;
        private System.Windows.Forms.ColumnHeader questionChoiceId;
        private System.Windows.Forms.ColumnHeader questionChoiceType;
        private System.Windows.Forms.ColumnHeader questionChoiceStem;
        private System.Windows.Forms.ColumnHeader questionChoiceA;
        private System.Windows.Forms.ColumnHeader questionChoiceB;
        private System.Windows.Forms.ColumnHeader questionChoiceC;
        private System.Windows.Forms.ColumnHeader questionChoiceD;
        private System.Windows.Forms.ColumnHeader questionChoiceAnswer;
        private System.Windows.Forms.ColumnHeader questionTxtId;
        private System.Windows.Forms.ColumnHeader questionType;
        private System.Windows.Forms.ColumnHeader questionTxtStem;
        private System.Windows.Forms.ColumnHeader questionTxtAnswer;
        private System.Windows.Forms.ToolStripMenuItem viewBtn;
    }
}