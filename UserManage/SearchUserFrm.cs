using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExamSystem.UserManage
{
    public partial class SearchUserFrm : Form
    {
        public SearchUserFrm()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (seacrhResult())
            {
                
            }
            else
            {
                MessageBox.Show("用户不存在");
            }

        }
        private bool seacrhResult()
        {
            bool flag = false;
            string sqlString = null;
            if (searchList.Items.Count > 0)
            {
                searchList.Items.Clear();
            }

            if (typeSeacrhCbo.Text == "账号：")
            {
                sqlString = string.Format("SELECT [userNum],[userName],[userPwd],[userGender],[userTel],[userClass],[userRole]FROM[ExamSystemDB].[dbo].[User]WHERE userNum like '%{0}%';", searchInputTxt.Text);
            }
            else if (typeSeacrhCbo.Text == "名字：")
            {
                sqlString = string.Format("SELECT [userNum],[userName],[userPwd],[userGender],[userTel],[userClass],[userRole]FROM[ExamSystemDB].[dbo].[User]WHERE userName like '%{0}%';", searchInputTxt.Text);
            }
            else if (typeSeacrhCbo.Text == "电话号码：")
            {
                sqlString = string.Format("SELECT [userNum],[userName],[userPwd],[userGender],[userTel],[userClass],[userRole]FROM[ExamSystemDB].[dbo].[User]WHERE userTel like '%{0}%';", searchInputTxt.Text);
            }
            DataSet sqlDataReader = ConnectSql.SelectData(sqlString);
            for(int i = 0; i < sqlDataReader.Tables[0].Rows.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem(sqlDataReader.Tables[0].Rows[i]["userNum"].ToString().Trim());
                listViewItem.SubItems.Add(sqlDataReader.Tables[0].Rows[i]["userName"].ToString().Trim());
                listViewItem.SubItems.Add(sqlDataReader.Tables[0].Rows[i]["userTel"].ToString().Trim());
                listViewItem.SubItems.Add(sqlDataReader.Tables[0].Rows[i]["userTel"].ToString().Trim());
                listViewItem.SubItems.Add(sqlDataReader.Tables[0].Rows[i]["userClass"].ToString().Trim());
                searchList.Items.Add(listViewItem);
                flag = true;
            }
            sqlDataReader.Dispose();
            return flag;
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            string sqlString = string.Format("DELETE FROM [dbo].[User] WHERE userNum = '{0}'",this.searchList.SelectedItems[0].Text);
            if (ConnectSql.ChangeData(sqlString))
            {
                MessageBox.Show("删除成功");
                seacrhResult();
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }
    }

    
}
