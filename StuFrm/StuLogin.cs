using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExamSystem.UserManage;
using CCWin;

namespace ExamSystem.StuFrm
{
    public partial class StuLogin : Skin_VS
    {
        public StuLogin()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (paperLv.Items.Count > 0)
                paperLv.Items.Clear();
            myExamPanel.Visible = true;
            scoreLv.Visible = false;
            string sqlString = string.Format(@"
                IF Exists(SELECT  * FROM stuScore Where stuId='{0}' AND paperScore=-1)
	                Begin 
		                SELECT [stuScore].[paperId],[paperName] FROM Paper right join stuScore on Paper.paperId = stuScore.paperId Where stuId ='{0}' AND stuScore.paperScore<0;
	                END
                ELSE
	                SELECT paperId,paperName FROM Paper WHere Paper.paperId=null;"
            , account.id);
            DataSet dataSet =  ConnectSql.SelectData(sqlString);
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem(dataSet.Tables[0].Rows[i][0].ToString().Trim());
                for (int j = 1; j < dataSet.Tables[0].Columns.Count; j++)
                {
                    listViewItem.SubItems.Add(dataSet.Tables[0].Rows[i][j].ToString().Trim());
                }
                paperLv.Items.Add(listViewItem);  
            }
        }

        private void joinExamBtn_Click(object sender, EventArgs e)
        {
            StuExamFrm stuExamFrm = new StuExamFrm(paperLv.SelectedItems[0].SubItems[0].Text);
            stuExamFrm.MdiParent = this.MdiParent;
            stuExamFrm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AddUserFrm addUserFrm = new AddUserFrm();
            addUserFrm.MdiParent = this.MdiParent;
            addUserFrm.Text = "我的信息";
            string sqlstring = string.Format("SELECT [userNum],[userName],[userPwd],[userGender],[userTel],[userClass],[userRole]FROM[ExamSystemDB].[dbo].[User] WHERE userNum='{0}';",account.id);
            DataSet dataSet = ConnectSql.SelectData(sqlstring);
            addUserFrm.userNumTxt.Text = dataSet.Tables[0].Rows[0][0].ToString().Trim();
            addUserFrm.userNameTxt.Text = dataSet.Tables[0].Rows[0][1].ToString().Trim();
            addUserFrm.userPwdTxt.Text = dataSet.Tables[0].Rows[0][2].ToString().Trim();
            addUserFrm.userPwd2Txt.Text = dataSet.Tables[0].Rows[0][2].ToString().Trim();
            addUserFrm.userMan.Checked = dataSet.Tables[0].Rows[0][3].ToString().Trim() == "男" ? true : false;
            addUserFrm.userFemale.Checked = dataSet.Tables[0].Rows[0][3].ToString().Trim() == "女" ? true : false;
            addUserFrm.userTelTxt.Text = dataSet.Tables[0].Rows[0][4].ToString().Trim();
            addUserFrm.userClassCbo.Text = dataSet.Tables[0].Rows[0][5].ToString().Trim() == "无" ? "无" : dataSet.Tables[0].Rows[0][5].ToString().Trim();
            addUserFrm.userRoleCbo.SelectedIndex = dataSet.Tables[0].Rows[0][6].ToString().Trim() == "教师" ? 2 : (dataSet.Tables[0].Rows[0][6].ToString().Trim() == "学生" ? 1 : 3);
            addUserFrm.resetBtn.Visible = false;
            addUserFrm.resetBtn.Enabled = false;
            addUserFrm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            scoreLv.Visible = true;
            myExamPanel.Visible = false;
            if (scoreLv.Items.Count > 0)
                scoreLv.Items.Clear();
            string sqlString = string.Format("SELECT [paperName],[paperScore] FROM Paper right join stuScore on Paper.paperId = stuScore.paperId Where stuId ='{0}'; ",account.id);
            DataSet dataSet = ConnectSql.SelectData(sqlString);
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                if (Convert.ToInt32(dataSet.Tables[0].Rows[i][1].ToString()) <= 0)
                {
                    continue;
                }
                else
                {
                    ListViewItem listViewItem = new ListViewItem(dataSet.Tables[0].Rows[i][0].ToString().Trim());
                    for (int j = 1; j < dataSet.Tables[0].Columns.Count; j++)
                    {
                        listViewItem.SubItems.Add(dataSet.Tables[0].Rows[i][j].ToString().Trim());
                    }
                    scoreLv.Items.Add(listViewItem);
                }
                
            }
        }
    }

}
