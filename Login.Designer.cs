
namespace ExamSystem
{
    partial class LoginUI
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUI));
            this.title = new System.Windows.Forms.Label();
            this.userLab = new System.Windows.Forms.Label();
            this.userRole = new System.Windows.Forms.Label();
            this.pwdLab = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.pwdTxt = new System.Windows.Forms.TextBox();
            this.roleCbo = new System.Windows.Forms.ComboBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.Window;
            this.title.Font = new System.Drawing.Font("宋体", 47.79832F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(204, 74);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(354, 80);
            this.title.TabIndex = 0;
            this.title.Text = "考试系统";
            // 
            // userLab
            // 
            this.userLab.AutoSize = true;
            this.userLab.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userLab.Location = new System.Drawing.Point(290, 242);
            this.userLab.Name = "userLab";
            this.userLab.Size = new System.Drawing.Size(37, 15);
            this.userLab.TabIndex = 1;
            this.userLab.Text = "账号";
            // 
            // userRole
            // 
            this.userRole.AutoSize = true;
            this.userRole.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userRole.Location = new System.Drawing.Point(290, 322);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(37, 15);
            this.userRole.TabIndex = 1;
            this.userRole.Text = "身份";
            // 
            // pwdLab
            // 
            this.pwdLab.AutoSize = true;
            this.pwdLab.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pwdLab.Location = new System.Drawing.Point(290, 282);
            this.pwdLab.Name = "pwdLab";
            this.pwdLab.Size = new System.Drawing.Size(37, 15);
            this.pwdLab.TabIndex = 1;
            this.pwdLab.Text = "密码";
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(343, 239);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(100, 25);
            this.userTxt.TabIndex = 2;
            // 
            // pwdTxt
            // 
            this.pwdTxt.Location = new System.Drawing.Point(343, 279);
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.Size = new System.Drawing.Size(100, 25);
            this.pwdTxt.TabIndex = 3;
            this.pwdTxt.UseSystemPasswordChar = true;
            // 
            // roleCbo
            // 
            this.roleCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleCbo.FormattingEnabled = true;
            this.roleCbo.Items.AddRange(new object[] {
            "请选择：",
            "学生",
            "教师",
            "管理员"});
            this.roleCbo.Location = new System.Drawing.Point(343, 319);
            this.roleCbo.Name = "roleCbo";
            this.roleCbo.Size = new System.Drawing.Size(100, 23);
            this.roleCbo.TabIndex = 4;
            this.roleCbo.SelectedIndex = 0;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(293, 358);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(55, 23);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "登陆";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(387, 358);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(56, 23);
            this.resetBtn.TabIndex = 7;
            this.resetBtn.Text = "重置";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(782, 554);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.roleCbo);
            this.Controls.Add(this.pwdTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.pwdLab);
            this.Controls.Add(this.userRole);
            this.Controls.Add(this.userLab);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label userLab;
        private System.Windows.Forms.Label userRole;
        private System.Windows.Forms.Label pwdLab;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox pwdTxt;
        private System.Windows.Forms.ComboBox roleCbo;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button resetBtn;

    }
}

