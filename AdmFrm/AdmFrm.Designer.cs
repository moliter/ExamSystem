
namespace ExamSystem.AdmFrm
{
    partial class AdmFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmFrm));
            this.AdmToolStrip = new System.Windows.Forms.ToolStrip();
            this.userOperatBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.addUserBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectUserBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdmToolStrip
            // 
            this.AdmToolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.AdmToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userOperatBtn});
            this.AdmToolStrip.Location = new System.Drawing.Point(8, 39);
            this.AdmToolStrip.Name = "AdmToolStrip";
            this.AdmToolStrip.Size = new System.Drawing.Size(587, 47);
            this.AdmToolStrip.TabIndex = 0;
            this.AdmToolStrip.Text = "toolStrip1";
            // 
            // userOperatBtn
            // 
            this.userOperatBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserBtn,
            this.SelectUserBtn});
            this.userOperatBtn.Image = ((System.Drawing.Image)(resources.GetObject("userOperatBtn.Image")));
            this.userOperatBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userOperatBtn.Name = "userOperatBtn";
            this.userOperatBtn.Size = new System.Drawing.Size(128, 44);
            this.userOperatBtn.Text = "用户管理";
            // 
            // addUserBtn
            // 
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(224, 26);
            this.addUserBtn.Text = "添加用户";
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // SelectUserBtn
            // 
            this.SelectUserBtn.Name = "SelectUserBtn";
            this.SelectUserBtn.Size = new System.Drawing.Size(224, 26);
            this.SelectUserBtn.Text = "查询用户";
            this.SelectUserBtn.Click += new System.EventHandler(this.selectUserBtn_Click);
            // 
            // AdmFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(603, 406);
            this.Controls.Add(this.AdmToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AdmFrm";
            this.Text = "管理员";
            this.AdmToolStrip.ResumeLayout(false);
            this.AdmToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip AdmToolStrip;
        private System.Windows.Forms.ToolStripSplitButton userOperatBtn;
        private System.Windows.Forms.ToolStripMenuItem addUserBtn;
        private System.Windows.Forms.ToolStripMenuItem SelectUserBtn;
    }
}