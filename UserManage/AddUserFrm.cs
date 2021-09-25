using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExamSystem.UserManage
{
    public partial class AddUserFrm : Form
    {
        public AddUserFrm()
        {
            InitializeComponent();
            this.IsMdiContainer = false;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            userNumTxt.ResetText();
            userNameTxt.ResetText();
            userPwdTxt.ResetText();
            userPwd2Txt.ResetText();
            userRoleCbo.SelectedIndex = 0;
            userClassCbo.SelectedIndex = 0;
            userMan.Checked = false;
            userFemale.Checked = false;
            userTelTxt.ResetText();
        }

        


        //检查输入是否合法
        private bool CheckInput()
        {
            bool flag = false;
            bool b1 = !string.IsNullOrEmpty(userNumTxt.Text);
            bool b2 = !string.IsNullOrEmpty(userPwdTxt.Text);
            bool b3 = (userMan.Checked || userFemale.Checked);
            bool b4 = !string.IsNullOrEmpty(userTelTxt.Text);
            bool b5 = (!(userClassCbo.SelectedIndex == 0 && userRoleCbo.Text == "学生"));
            bool b6 = ((userRoleCbo.SelectedIndex != 0));
            if (b1 && b2 && b3 && b4 && b5 && b6)
            {
               
                if (((userRoleCbo.Text == "学生") && (userClassCbo.SelectedIndex != 0)))
                {
                    if (userPwd2Txt.Text == userPwdTxt.Text)
                    {
                        flag = true;
                    }
                    else
                    {
                        MessageBox.Show("输入的密码不相同");
                        flag = false;
                    }
                }
                if ((userRoleCbo.Text == "教师") || (userRoleCbo.Text == "管理员"))
                {
                    if (userPwd2Txt.Text == userPwdTxt.Text)
                    {
                        flag = true;
                    }
                    else
                    {
                        MessageBox.Show("输入的密码不相同");
                        flag = false;
                    }
                }
            }
            else
            {
                if(string.IsNullOrEmpty(userNumTxt.Text)) { userNumTxt.BackColor = Color.Pink; }
                if(string.IsNullOrEmpty(userNameTxt.Text)) { userNameTxt.BackColor = Color.Pink; }
                if(string.IsNullOrEmpty(userPwdTxt.Text)) { userPwdTxt.BackColor = Color.Pink; }
                if(string.IsNullOrEmpty(userPwd2Txt.Text)) { userPwd2Txt.BackColor = Color.Pink; }
                if(string.IsNullOrEmpty(userTelTxt.Text)) { userTelTxt.BackColor = Color.Pink; }
                if(!(userMan.Checked||userFemale.Checked)) { userGenderPanel.BackColor = Color.Pink; }
                if(userClassCbo.SelectedIndex == 0 && userRoleCbo.Text == "学生") { userClassCbo.BackColor = Color.Pink; }
                if(userRoleCbo.SelectedIndex == 0) { userRoleCbo.BackColor = Color.Pink;}
            }
            return flag;
        }

        //点击添加事件
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInput())
                {
                    if (ConnectSql.ChangeData(addUserSqlString()))
                    {
                        MessageBox.Show("创建用户成功");
                    }
                    else
                    {
                        MessageBox.Show("创建用户失败");
                    }
                }
            }
            catch(Exception ex)
            {
                throw (ex);
            }
            
        }

        public string addUserSqlString()
        {
            string sqlUserNum = userNumTxt.Text;
            string sqlUserName = userNameTxt.Text;
            string sqlUserPwd = userPwdTxt.Text;
            string sqlUserGender = userMan.Checked ? "男" : "女";
            string sqlUserTel = userTelTxt.Text;
            string sqlUserClass = userClassCbo.Text;
            string sqlUserRole = userRoleCbo.Text;
            if (userRoleCbo.Text != "学生") { sqlUserClass = "无"; }
            string sqlString = String.Format("INSERT INTO [dbo].[User] ([userNum] ,[userName],[userPwd],[userGender],[userTel],[userClass],[userRole]) VALUES ('{0}', '{1}', '{2}','{3}', '{4}', '{5}', '{6}')", sqlUserNum, sqlUserName, sqlUserPwd, sqlUserGender, sqlUserTel, sqlUserClass, sqlUserRole);
            return sqlString;
        }
    }
}
