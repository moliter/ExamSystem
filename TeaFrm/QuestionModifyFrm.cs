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

    public partial class QuestionModifyFrm : Skin_VS
    {
        public QuestionModifyFrm()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            questionChoiceLv.Items.Clear();
            questionTxtLv.Items.Clear();
            searchData();
        }
        private void searchData()
        {
            string keyType = this.searchTypeCbo.Text.Trim() == "题干：" ? "questionStem" : (this.searchTypeCbo.Text.Trim() == "题库编号：" ? "questionId" : "questionAnswer");
            string keyWord = this.searchKeyTxt.Text.Trim();
            string sqlChoiceString = string.Format(@"SELECT [questionId],[questionType],[questionStem],[questionOptionA] ,[questionOptionB],[questionOptionC],[questionOptionD],[questionAnswer]FROM [dbo].[ChoiceQuestion] where {0} LIKE '%{1}%';", keyType, keyWord);
            string sqlTxtString = string.Format(@"SELECT [questionId],[questionType],[questionStem],[questionAnswer]FROM [dbo].[TxtQuestion]Where {0} LIKE '%{1}%';", keyType, keyWord);
            DataSet dataSetChoice = ConnectSql.SelectData(sqlChoiceString);
            DataSet dataSetTxt = ConnectSql.SelectData(sqlTxtString);
            ChoiceLv(dataSetChoice);
            TxtLv(dataSetTxt);
        }

        private bool ChoiceLv(DataSet dataSet)
        {
            bool flag = false;
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                
                ListViewItem listViewItem = new ListViewItem(dataSet.Tables[0].Rows[i][0].ToString().Trim());
                for (int j = 1; j < dataSet.Tables[0].Columns.Count; j++)
                {
                    listViewItem.SubItems.Add(dataSet.Tables[0].Rows[i][j].ToString().Trim());
                }
                questionChoiceLv.Items.Add(listViewItem);
                flag = true;
                
            }
            if (dataSet.Tables[0].Rows.Count <= 0) { flag = true; }
            dataSet.Dispose();
            return flag;
        }

        private bool TxtLv(DataSet dataSet)
        {
            bool flag = false;
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem(dataSet.Tables[0].Rows[i][0].ToString().Trim());
                for (int j = 1; j < dataSet.Tables[0].Columns.Count; j++)
                {
                    listViewItem.SubItems.Add(dataSet.Tables[0].Rows[i][j].ToString().Trim());
                }
                questionTxtLv.Items.Add(listViewItem);
                flag = true;
                
            }
            if (dataSet.Tables[0].Rows.Count <= 0) { flag = true; }
            dataSet.Dispose();
            return flag;
        }

        private void modifyClickBtn_Click(object sender, EventArgs e)
        {
            AddQuestionFrm modifyQuestionFrm = new AddQuestionFrm();
            modifyQuestionFrm.MdiParent = this.MdiParent;
            modifyQuestionFrm.Text = "修改题目";
            ContextToModifyFrm(modifyQuestionFrm);
            modifyQuestionFrm.Show();
        }

        private void ContextToModifyFrm(AddQuestionFrm modifyQuestionFrm)
        {
            modifyQuestionFrm.AddQuestionReset.Enabled = false;
            modifyQuestionFrm.questionTxtResetBtn.Enabled = false;
            if(this.questionChoiceLv.SelectedItems.Count > 0 && this.questionChoiceLv.SelectedItems[0].SubItems[1].Text == "choice" )
            {
                modifyQuestionFrm.questionTypeCbo.Enabled = false;
                modifyQuestionFrm.questionTypeCbo.SelectedIndex = 0;
                UpdataId.questionChoiceId = this.questionChoiceLv.SelectedItems[0].SubItems[0].Text;
                modifyQuestionFrm.questionStemTxt.Text = this.questionChoiceLv.SelectedItems[0].SubItems[2].Text;
                modifyQuestionFrm.questionOptionATxt.Text =  this.questionChoiceLv.SelectedItems[0].SubItems[3].Text;
                modifyQuestionFrm.questionOptionBTxt.Text = this.questionChoiceLv.SelectedItems[0].SubItems[4].Text;
                modifyQuestionFrm.questionOptionCTxt.Text = this.questionChoiceLv.SelectedItems[0].SubItems[5].Text;
                modifyQuestionFrm.questionOptionDTxt.Text = this.questionChoiceLv.SelectedItems[0].SubItems[6].Text;
                modifyQuestionFrm.questionAnswerCbo.SelectedIndex = (this.questionChoiceLv.SelectedItems[0].SubItems[7].Text.Trim() =="A") ? 1 : (this.questionChoiceLv.SelectedItems[0].SubItems[7].Text.Trim() == "B" ? 2 : (this.questionChoiceLv.SelectedItems[0].SubItems[7].Text.Trim() == "C" ? 3 :(this.questionChoiceLv.SelectedItems[0].SubItems[7].Text.Trim() == "D"?4:0)));
                modifyQuestionFrm.questionStemTxtTxt.Clear();
                modifyQuestionFrm.questionAnswerTxtTxt.Clear();
            }
            if(this.questionTxtLv.SelectedItems.Count > 0 && this.questionTxtLv.SelectedItems[0].SubItems[1].Text == "txt" )
            {
                modifyQuestionFrm.questionTypeCbo.Enabled = false;
                modifyQuestionFrm.questionTypeCbo.SelectedIndex = 1;
                UpdataId.questionTxtId = this.questionTxtLv.SelectedItems[0].SubItems[0].Text;
                modifyQuestionFrm.questionStemTxtTxt.Text = this.questionTxtLv.SelectedItems[0].SubItems[2].Text;
                modifyQuestionFrm.questionAnswerTxtTxt.Text = this.questionTxtLv.SelectedItems[0].SubItems[3].Text;

            }
            
        }
        public static class UpdataId
        {
            static public string questionChoiceId;
            static public string questionTxtId;
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            AddQuestionFrm viewQuestionFrm = new AddQuestionFrm();
            viewQuestionFrm.MdiParent = this.MdiParent;
            viewQuestionFrm.Text = "查看题目";
            ContextToModifyFrm(viewQuestionFrm);
            viewQuestionFrm.AddQuestionSubmitBtn.Enabled = false;
            viewQuestionFrm.questionTxtSubmitBtn.Enabled = false;
            viewQuestionFrm.Show();
        }

        private void delClickBtn_Click(object sender, EventArgs e)
        {
            if(this.questionChoiceLv.SelectedItems.Count > 0)
            {
                string id = this.questionChoiceLv.SelectedItems[0].SubItems[0].Text;
                string sqlstring = string.Format("DELETE FROM [dbo].[ChoiceQuestion] WHERE questionId = {0}; ", id);
                ConnectSql.ChangeData(sqlstring);
                searchBtn.PerformClick();
            }

            if (this.questionTxtLv.SelectedItems.Count > 0)
            {
                string id = this.questionTxtLv.SelectedItems[0].SubItems[0].Text;
                string sqlstring = string.Format("DELETE FROM [dbo].[TxtQuestion] WHERE questionId = {0}; ", id);
                ConnectSql.ChangeData(sqlstring);
                searchBtn.PerformClick();
            }
        }
    }
}
