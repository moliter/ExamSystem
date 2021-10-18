
namespace ExamSystem.TeaFrm
{
    partial class PaperMkFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaperMkFrm));
            this.AddChoiceLv = new System.Windows.Forms.ListView();
            this.questionChoiceId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionChoiceType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionChoiceStem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionChoiceA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionChoiceB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionChoiceC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionChoiceD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionChoiceAnswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.AllSelectBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.AddTxtLv = new System.Windows.Forms.ListView();
            this.qustionTxtNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionTxtType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionTxtStem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionTxtAnswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaperChoiceLv = new System.Windows.Forms.ListView();
            this.PaperQuestionNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaperQuestionType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaperQuestionStem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaperQuestionChoiceA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaperQuestionChoiceB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaperQuestionChoiceC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaperQuestionChoiceD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaperQuestionAnswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AllSelectTxtBtn = new System.Windows.Forms.Button();
            this.PaperTxtLv = new System.Windows.Forms.ListView();
            this.PaperTxtNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaperTxtType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaperTxtStem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaperTxtAnswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionTxtId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaperSubmit = new System.Windows.Forms.Button();
            this.PaperNameTxt = new System.Windows.Forms.TextBox();
            this.PaperNameLab = new System.Windows.Forms.Label();
            this.paperClassLab = new System.Windows.Forms.Label();
            this.paperClassCbo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.choiceNup = new System.Windows.Forms.NumericUpDown();
            this.txtNup = new System.Windows.Forms.NumericUpDown();
            this.choiceNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.choiceNup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNup)).BeginInit();
            this.SuspendLayout();
            // 
            // AddChoiceLv
            // 
            this.AddChoiceLv.CheckBoxes = true;
            this.AddChoiceLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.questionChoiceId,
            this.questionChoiceType,
            this.questionChoiceStem,
            this.questionChoiceA,
            this.questionChoiceB,
            this.questionChoiceC,
            this.questionChoiceD,
            this.questionChoiceAnswer});
            this.AddChoiceLv.FullRowSelect = true;
            this.AddChoiceLv.HideSelection = false;
            this.AddChoiceLv.Location = new System.Drawing.Point(35, 98);
            this.AddChoiceLv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddChoiceLv.Name = "AddChoiceLv";
            this.AddChoiceLv.Size = new System.Drawing.Size(537, 222);
            this.AddChoiceLv.TabIndex = 1;
            this.AddChoiceLv.UseCompatibleStateImageBehavior = false;
            this.AddChoiceLv.View = System.Windows.Forms.View.Details;
            // 
            // questionChoiceId
            // 
            this.questionChoiceId.Text = "题库编号";
            this.questionChoiceId.Width = 62;
            // 
            // questionChoiceType
            // 
            this.questionChoiceType.Text = "题目类型";
            this.questionChoiceType.Width = 65;
            // 
            // questionChoiceStem
            // 
            this.questionChoiceStem.Text = "题干";
            this.questionChoiceStem.Width = 47;
            // 
            // questionChoiceA
            // 
            this.questionChoiceA.Text = "选项A";
            // 
            // questionChoiceB
            // 
            this.questionChoiceB.Text = "选项B";
            this.questionChoiceB.Width = 65;
            // 
            // questionChoiceC
            // 
            this.questionChoiceC.Text = "选项C";
            this.questionChoiceC.Width = 53;
            // 
            // questionChoiceD
            // 
            this.questionChoiceD.Text = "选项D";
            this.questionChoiceD.Width = 54;
            // 
            // questionChoiceAnswer
            // 
            this.questionChoiceAnswer.Text = "选择题答案";
            this.questionChoiceAnswer.Width = 90;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(592, 298);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 36);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "添加";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(592, 362);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 29);
            this.DelBtn.TabIndex = 3;
            this.DelBtn.Text = "移除";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // AllSelectBtn
            // 
            this.AllSelectBtn.Location = new System.Drawing.Point(35, 336);
            this.AllSelectBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AllSelectBtn.Name = "AllSelectBtn";
            this.AllSelectBtn.Size = new System.Drawing.Size(77, 36);
            this.AllSelectBtn.TabIndex = 4;
            this.AllSelectBtn.Text = "全选";
            this.AllSelectBtn.UseVisualStyleBackColor = true;
            this.AllSelectBtn.Click += new System.EventHandler(this.AllSelectBtn_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(32, 55);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(265, 25);
            this.searchTxt.TabIndex = 7;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(309, 51);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 35);
            this.searchBtn.TabIndex = 8;
            this.searchBtn.Text = "搜索";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // AddTxtLv
            // 
            this.AddTxtLv.CheckBoxes = true;
            this.AddTxtLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.qustionTxtNum,
            this.questionTxtType,
            this.questionTxtStem,
            this.questionTxtAnswer});
            this.AddTxtLv.FullRowSelect = true;
            this.AddTxtLv.HideSelection = false;
            this.AddTxtLv.Location = new System.Drawing.Point(35, 378);
            this.AddTxtLv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddTxtLv.Name = "AddTxtLv";
            this.AddTxtLv.Size = new System.Drawing.Size(537, 212);
            this.AddTxtLv.TabIndex = 10;
            this.AddTxtLv.UseCompatibleStateImageBehavior = false;
            this.AddTxtLv.View = System.Windows.Forms.View.Details;
            // 
            // qustionTxtNum
            // 
            this.qustionTxtNum.Text = "题库编号";
            this.qustionTxtNum.Width = 82;
            // 
            // questionTxtType
            // 
            this.questionTxtType.Text = "题目类型";
            this.questionTxtType.Width = 79;
            // 
            // questionTxtStem
            // 
            this.questionTxtStem.Text = "题干";
            this.questionTxtStem.Width = 274;
            // 
            // questionTxtAnswer
            // 
            this.questionTxtAnswer.Text = "题目答案";
            this.questionTxtAnswer.Width = 98;
            // 
            // PaperChoiceLv
            // 
            this.PaperChoiceLv.CheckBoxes = true;
            this.PaperChoiceLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PaperQuestionNum,
            this.PaperQuestionType,
            this.PaperQuestionStem,
            this.PaperQuestionChoiceA,
            this.PaperQuestionChoiceB,
            this.PaperQuestionChoiceC,
            this.PaperQuestionChoiceD,
            this.PaperQuestionAnswer});
            this.PaperChoiceLv.FullRowSelect = true;
            this.PaperChoiceLv.HideSelection = false;
            this.PaperChoiceLv.Location = new System.Drawing.Point(687, 98);
            this.PaperChoiceLv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaperChoiceLv.Name = "PaperChoiceLv";
            this.PaperChoiceLv.Size = new System.Drawing.Size(524, 222);
            this.PaperChoiceLv.TabIndex = 1;
            this.PaperChoiceLv.UseCompatibleStateImageBehavior = false;
            this.PaperChoiceLv.View = System.Windows.Forms.View.Details;
            // 
            // PaperQuestionNum
            // 
            this.PaperQuestionNum.Text = "题库编号";
            this.PaperQuestionNum.Width = 72;
            // 
            // PaperQuestionType
            // 
            this.PaperQuestionType.Text = "题目类型";
            this.PaperQuestionType.Width = 75;
            // 
            // PaperQuestionStem
            // 
            this.PaperQuestionStem.Text = "题干";
            this.PaperQuestionStem.Width = 45;
            // 
            // PaperQuestionChoiceA
            // 
            this.PaperQuestionChoiceA.Text = "选项A";
            // 
            // PaperQuestionChoiceB
            // 
            this.PaperQuestionChoiceB.Text = "选项B";
            this.PaperQuestionChoiceB.Width = 65;
            // 
            // PaperQuestionChoiceC
            // 
            this.PaperQuestionChoiceC.Text = "选项C";
            this.PaperQuestionChoiceC.Width = 53;
            // 
            // PaperQuestionChoiceD
            // 
            this.PaperQuestionChoiceD.Text = "选项D";
            this.PaperQuestionChoiceD.Width = 54;
            // 
            // PaperQuestionAnswer
            // 
            this.PaperQuestionAnswer.Text = "选择题答案";
            this.PaperQuestionAnswer.Width = 90;
            // 
            // AllSelectTxtBtn
            // 
            this.AllSelectTxtBtn.Location = new System.Drawing.Point(35, 605);
            this.AllSelectTxtBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AllSelectTxtBtn.Name = "AllSelectTxtBtn";
            this.AllSelectTxtBtn.Size = new System.Drawing.Size(77, 41);
            this.AllSelectTxtBtn.TabIndex = 4;
            this.AllSelectTxtBtn.Text = "全选";
            this.AllSelectTxtBtn.UseVisualStyleBackColor = true;
            this.AllSelectTxtBtn.Click += new System.EventHandler(this.AllSelectTxtBtn_Click);
            // 
            // PaperTxtLv
            // 
            this.PaperTxtLv.CheckBoxes = true;
            this.PaperTxtLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PaperTxtNum,
            this.PaperTxtType,
            this.PaperTxtStem,
            this.PaperTxtAnswer,
            this.questionTxtId});
            this.PaperTxtLv.FullRowSelect = true;
            this.PaperTxtLv.HideSelection = false;
            this.PaperTxtLv.Location = new System.Drawing.Point(687, 378);
            this.PaperTxtLv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaperTxtLv.Name = "PaperTxtLv";
            this.PaperTxtLv.Size = new System.Drawing.Size(524, 212);
            this.PaperTxtLv.TabIndex = 10;
            this.PaperTxtLv.UseCompatibleStateImageBehavior = false;
            this.PaperTxtLv.View = System.Windows.Forms.View.Details;
            // 
            // PaperTxtNum
            // 
            this.PaperTxtNum.Text = "题库编号";
            this.PaperTxtNum.Width = 82;
            // 
            // PaperTxtType
            // 
            this.PaperTxtType.Text = "题目类型";
            this.PaperTxtType.Width = 79;
            // 
            // PaperTxtStem
            // 
            this.PaperTxtStem.Text = "题干";
            this.PaperTxtStem.Width = 259;
            // 
            // PaperTxtAnswer
            // 
            this.PaperTxtAnswer.Text = "题目答案";
            this.PaperTxtAnswer.Width = 98;
            // 
            // questionTxtId
            // 
            this.questionTxtId.Text = "题库编号";
            this.questionTxtId.Width = 0;
            // 
            // PaperSubmit
            // 
            this.PaperSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PaperSubmit.Location = new System.Drawing.Point(770, 659);
            this.PaperSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaperSubmit.Name = "PaperSubmit";
            this.PaperSubmit.Size = new System.Drawing.Size(96, 29);
            this.PaperSubmit.TabIndex = 11;
            this.PaperSubmit.Text = "试卷生成";
            this.PaperSubmit.UseVisualStyleBackColor = false;
            this.PaperSubmit.Click += new System.EventHandler(this.PaperSubmit_Click);
            // 
            // PaperNameTxt
            // 
            this.PaperNameTxt.Location = new System.Drawing.Point(513, 624);
            this.PaperNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaperNameTxt.Name = "PaperNameTxt";
            this.PaperNameTxt.Size = new System.Drawing.Size(237, 25);
            this.PaperNameTxt.TabIndex = 12;
            // 
            // PaperNameLab
            // 
            this.PaperNameLab.AutoSize = true;
            this.PaperNameLab.BackColor = System.Drawing.Color.Transparent;
            this.PaperNameLab.ForeColor = System.Drawing.Color.White;
            this.PaperNameLab.Location = new System.Drawing.Point(439, 631);
            this.PaperNameLab.Name = "PaperNameLab";
            this.PaperNameLab.Size = new System.Drawing.Size(67, 15);
            this.PaperNameLab.TabIndex = 13;
            this.PaperNameLab.Text = "试卷名：";
            // 
            // paperClassLab
            // 
            this.paperClassLab.AutoSize = true;
            this.paperClassLab.BackColor = System.Drawing.Color.Transparent;
            this.paperClassLab.ForeColor = System.Drawing.Color.White;
            this.paperClassLab.Location = new System.Drawing.Point(424, 669);
            this.paperClassLab.Name = "paperClassLab";
            this.paperClassLab.Size = new System.Drawing.Size(82, 15);
            this.paperClassLab.TabIndex = 14;
            this.paperClassLab.Text = "考试班级：";
            // 
            // paperClassCbo
            // 
            this.paperClassCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paperClassCbo.FormattingEnabled = true;
            this.paperClassCbo.Items.AddRange(new object[] {
            "请选择：",
            "2020级计算机",
            "2019级计算机"});
            this.paperClassCbo.Location = new System.Drawing.Point(513, 661);
            this.paperClassCbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paperClassCbo.Name = "paperClassCbo";
            this.paperClassCbo.Size = new System.Drawing.Size(236, 23);
            this.paperClassCbo.TabIndex = 15;
            this.paperClassCbo.SelectedIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(1047, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "随机选择题目";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // choiceNup
            // 
            this.choiceNup.Location = new System.Drawing.Point(812, 55);
            this.choiceNup.Name = "choiceNup";
            this.choiceNup.Size = new System.Drawing.Size(44, 25);
            this.choiceNup.TabIndex = 17;
            // 
            // txtNup
            // 
            this.txtNup.Location = new System.Drawing.Point(983, 56);
            this.txtNup.Name = "txtNup";
            this.txtNup.Size = new System.Drawing.Size(44, 25);
            this.txtNup.TabIndex = 17;
            // 
            // choiceNum
            // 
            this.choiceNum.AutoSize = true;
            this.choiceNum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.choiceNum.Location = new System.Drawing.Point(709, 57);
            this.choiceNum.Name = "choiceNum";
            this.choiceNum.Size = new System.Drawing.Size(97, 15);
            this.choiceNum.TabIndex = 18;
            this.choiceNum.Text = "选择题数量：";
            // 
            // txtNum
            // 
            this.txtNum.AutoSize = true;
            this.txtNum.ForeColor = System.Drawing.Color.White;
            this.txtNum.Location = new System.Drawing.Point(871, 58);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(97, 15);
            this.txtNum.TabIndex = 19;
            this.txtNum.Text = "文本题数量：";
            // 
            // PaperMkFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1246, 694);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.choiceNum);
            this.Controls.Add(this.txtNup);
            this.Controls.Add(this.choiceNup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.paperClassCbo);
            this.Controls.Add(this.paperClassLab);
            this.Controls.Add(this.PaperNameLab);
            this.Controls.Add(this.PaperNameTxt);
            this.Controls.Add(this.PaperSubmit);
            this.Controls.Add(this.PaperTxtLv);
            this.Controls.Add(this.AddTxtLv);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.AllSelectTxtBtn);
            this.Controls.Add(this.AllSelectBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.PaperChoiceLv);
            this.Controls.Add(this.AddChoiceLv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "PaperMkFrm";
            this.Text = "试卷制作";
            ((System.ComponentModel.ISupportInitialize)(this.choiceNup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView AddChoiceLv;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button AllSelectBtn;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ColumnHeader questionChoiceId;
        private System.Windows.Forms.ColumnHeader questionChoiceType;
        private System.Windows.Forms.ColumnHeader questionChoiceStem;
        private System.Windows.Forms.ColumnHeader questionChoiceA;
        private System.Windows.Forms.ColumnHeader questionChoiceB;
        private System.Windows.Forms.ColumnHeader questionChoiceC;
        private System.Windows.Forms.ColumnHeader questionChoiceD;
        private System.Windows.Forms.ColumnHeader questionChoiceAnswer;
        private System.Windows.Forms.ListView AddTxtLv;
        private System.Windows.Forms.ColumnHeader qustionTxtNum;
        private System.Windows.Forms.ColumnHeader questionTxtType;
        private System.Windows.Forms.ColumnHeader questionTxtStem;
        private System.Windows.Forms.ColumnHeader questionTxtAnswer;
        private System.Windows.Forms.ListView PaperChoiceLv;
        private System.Windows.Forms.ColumnHeader PaperQuestionNum;
        private System.Windows.Forms.ColumnHeader PaperQuestionType;
        private System.Windows.Forms.ColumnHeader PaperQuestionStem;
        private System.Windows.Forms.ColumnHeader PaperQuestionChoiceA;
        private System.Windows.Forms.ColumnHeader PaperQuestionChoiceB;
        private System.Windows.Forms.ColumnHeader PaperQuestionChoiceC;
        private System.Windows.Forms.ColumnHeader PaperQuestionChoiceD;
        private System.Windows.Forms.ColumnHeader PaperQuestionAnswer;
        private System.Windows.Forms.Button AllSelectTxtBtn;
        private System.Windows.Forms.ListView PaperTxtLv;
        private System.Windows.Forms.ColumnHeader PaperTxtNum;
        private System.Windows.Forms.ColumnHeader PaperTxtType;
        private System.Windows.Forms.ColumnHeader PaperTxtStem;
        private System.Windows.Forms.ColumnHeader PaperTxtAnswer;
        private System.Windows.Forms.Button PaperSubmit;
        private System.Windows.Forms.TextBox PaperNameTxt;
        private System.Windows.Forms.Label PaperNameLab;
        private System.Windows.Forms.ColumnHeader questionTxtId;
        private System.Windows.Forms.Label paperClassLab;
        private System.Windows.Forms.ComboBox paperClassCbo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown choiceNup;
        private System.Windows.Forms.NumericUpDown txtNup;
        private System.Windows.Forms.Label choiceNum;
        private System.Windows.Forms.Label txtNum;
    }
}