using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace ExamSystem.TeaFrm
{
    public partial class correctFrm : Skin_VS
    {
        public correctFrm()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchResultLv.Items.Count > 0)
                searchResultLv.Items.Clear();
            GetQuestionAnswer();
        }

        private void GetQuestionAnswer()
        {
            if (check())
            {
                string sqlNameString = string.Format("SELECT [stuScore].[paperId],[paperName] FROM Paper right join stuScore on Paper.paperId = stuScore.paperId Where paperName LIKE '%{0}%' AND stuScore.paperScore<0;", this.paperNameTxt.Text);
                DataSet idDataSet = ConnectSql.SelectData(sqlNameString);
                List<int> tpaperId = new List<int>();
                List < string > tpaperName = new List<string>();
                for (int i = 0; i < idDataSet.Tables[0].Rows.Count; i++)
                {
                    tpaperId.Add((int)idDataSet.Tables[0].Rows[i][0]);
                    tpaperName.Add(idDataSet.Tables[0].Rows[i][1].ToString());
                }

                for(int i=0;i < idDataSet.Tables[0].Rows.Count;i++)
                {
                    try
                    {
                        string sqlIdString = string.Format("SELECT [paperId],[stuId] FROM [ExamSystemDB].[dbo].[paperAnswer] WHERE [paperId] = {0};", tpaperId[i]);
                        DataSet dataSet = ConnectSql.SelectData(sqlIdString);
                        ListViewItem listViewItem = new ListViewItem(dataSet.Tables[0].Rows[0][0].ToString());
                        listViewItem.SubItems.Add(dataSet.Tables[0].Rows[0][1].ToString());
                        listViewItem.SubItems.Add(tpaperName[i]);
                        searchResultLv.Items.Add(listViewItem);
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("没有任何行"))
                        {
                            MessageBox.Show("没有该名字的试卷");
                            break;
                        }
                    }   
                }
            }
        }

        private bool check()
        {
            bool flag = false;
            if (string.IsNullOrEmpty(this.paperNameTxt.Text))
            {
                MessageBox.Show("请输入考试名称");
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        private void 批改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorrectQuestionFrm correctQuestionFrm = new CorrectQuestionFrm(this.searchResultLv.SelectedItems[0].SubItems[0].Text.ToString(),this.searchResultLv.SelectedItems[0].SubItems[1].Text.ToString());
            correctQuestionFrm.MdiParent = this.MdiParent;
            correctQuestionFrm.Show();
        }
    }
}
