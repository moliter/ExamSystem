using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace ExamSystem.UserManage
{
    public partial class AddUserFrm : Skin_VS
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

        public delegate bool Op();
        //点击添加事件
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInput())
                {
                    Op op = null;
                    if(this.Text == ("修改用户"))
                    {
                        op = updataDate;
                    }else if(this.Text == ("我的信息"))
                    {
                        op = updataDate;
                    }
                    else if(this.Text == ("添加用户"))
                    {
                        op = OperatAddUser;
                    }
                    if (op())
                    {
                        MessageBox.Show("操作成功");
                        resetBtn.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("操作失败");
                    }                 
                }
                else
                {
                    MessageBox.Show("输入不合法");
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

        public bool updataDate()
        {
            bool flag = false;
            string sqlString = string.Format("UPDATE [dbo].[User] SET[userNum] = '{0}',[userName] = '{1}',[userPwd] = '{2}',[userGender] = '{3}',[userTel] = '{4}',[userClass] = '{5}',[userRole] = '{6}' WHERE userNum = '{0}'; ",
                     this.userNumTxt.Text,
                     this.userNameTxt.Text,
                     this.userPwdTxt.Text,
                     this.userMan.Checked ? "男" : "女",
                     this.userTelTxt.Text,
                     this.userClassCbo.Text == "请选择："?"无": this.userClassCbo.Text,
                     this.userRoleCbo.Text
                );
            if (ConnectSql.ChangeData(sqlString))
            {
                flag = true;
            }
            return flag;
        }

        public bool OperatAddUser()
        {
            bool flag = false;
            if (ConnectSql.ChangeData(addUserSqlString()))
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }
    }
}
