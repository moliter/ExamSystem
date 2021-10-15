using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExamSystem;
using CCWin;

namespace ExamSystem
{
    public partial class LoginUI : Skin_VS
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        //检测用户输入的合法性
        public  bool CheckLogin()
        {
            bool flag = false;
            if (String.IsNullOrEmpty(userTxt.Text)||String.IsNullOrEmpty(pwdTxt.Text))
            {
                MessageBox.Show("账号或密码不能为空");
            }else if((roleCbo.SelectedIndex == 0))
            {
                MessageBox.Show("请选择身份");
            }
            else
            {
                flag = true;
            }
            return flag;
        }


        //生成sql字符串
        public string LoginSqlString()
        {
            string sqlRole = roleCbo.Text == "教师" ? "教师" : (roleCbo.Text=="学生"? "学生" : "管理员");
            string sqlAccount = userTxt.Text;
            string sqlPwd = pwdTxt.Text;
            string sqlString = string.Format("SELECT Count(*)  FROM [dbo].[User]  where userNum = '{1}' and userPwd = '{2}' and userRole = '{0}';", sqlRole,sqlAccount, sqlPwd);
            account.id = sqlAccount;
            return sqlString;
        }

        //登陆点击事件
        private void loginBtn_Click(object sender, EventArgs e)
        {
            
            bool result = false;
            if (CheckLogin())
            {
                try
                {
                    result = ConnectSql.SelectDataExist(LoginSqlString());
                }
                catch
                {
                    MessageBox.Show("连接数据库出错");
                }
                if (result && roleCbo.Text == "管理员")
                {
                    this.Close();
                    FrmStart.frmFlag = FrmFlag.startAdm;
                }
                else if (result && roleCbo.Text == "教师")
                {
                    this.Close();
                    FrmStart.frmFlag = FrmFlag.startTea;
                }
                else if (result && roleCbo.Text == "学生")
                {
                    this.Close();
                    FrmStart.frmFlag = FrmFlag.startStu;
                }
                else
                {
                    MessageBox.Show("账号密码错误");
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            userTxt.ResetText();
            pwdTxt.ResetText();
            roleCbo.SelectedIndex = 0;
        }
    }
}
