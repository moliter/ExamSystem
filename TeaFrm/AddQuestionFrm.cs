using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExamSystem.TeaFrm;
using CCWin;

namespace ExamSystem.TeaFrm
{
    public partial class AddQuestionFrm : Skin_VS
    {
        public AddQuestionFrm()
        {
            InitializeComponent();
        }

        private void AddQuestionSubmitBtn_Click(object sender, EventArgs e)
        {
            string questionType = this.questionTypeCbo.SelectedIndex == 0 ? "choice" : "txt";
            string questionStem = this.questionStemTxt.Text;
            string questionOptionA = string.IsNullOrEmpty(this.questionOptionATxt.Text)?"": this.questionOptionATxt.Text;
            string questionOptionB = string.IsNullOrEmpty(this.questionOptionBTxt.Text)?"": this.questionOptionBTxt.Text;
            string questionOptionC = string.IsNullOrEmpty(this.questionOptionCTxt.Text)?"": this.questionOptionCTxt.Text;
            string questionOptionD = string.IsNullOrEmpty(this.questionOptionDTxt.Text)?"": this.questionOptionDTxt.Text;
            string sqlString = "";
            string questionAnswer = this.questionAnswerCbo.SelectedIndex == 1 ? "A" : (this.questionAnswerCbo.SelectedIndex == 2 ? "B" : (this.questionAnswerCbo.SelectedIndex == 3 ? "C" : (this.questionAnswerCbo.SelectedIndex == 4)? "D":"请选择"));
            if(this.Text == "添加题目")
            {
                sqlString = string.Format(@"INSERT INTO [dbo].[ChoiceQuestion]([questionType],[questionStem],[questionOptionA],[questionOptionB],[questionOptionC],[questionOptionD],[questionAnswer])VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                questionType, questionStem, questionOptionA, questionOptionB, questionOptionC, questionOptionD, questionAnswer);
            }else if(this.Text == "修改题目"){
                sqlString = string.Format(@"UPDATE [dbo].[ChoiceQuestion] SET [questionType] = '{0}',[questionStem] = '{1}',[questionOptionA] = '{2}',[questionOptionB] ='{3}',[questionOptionC] = '{4}',[questionOptionD] = '{5}' ,[questionAnswer] = '{6}' WHERE questionId = {7}", questionType, questionStem, questionOptionA, questionOptionB, questionOptionC, questionOptionD, questionAnswer, QuestionModifyFrm.UpdataId.questionChoiceId);
            }
            
            if (InputChoiceCheck() && ConnectSql.ChangeData(sqlString))
            {
                MessageBox.Show("提交成功");
                AddQuestionReset.PerformClick();
            }
            else
            {
                MessageBox.Show("提交失败");
            }
        }

        private bool InputChoiceCheck()
        {
            bool flag = false;
            if (string.IsNullOrEmpty(this.questionStemTxt.Text)||questionAnswerCbo.SelectedIndex==0)
            {
                MessageBox.Show("题干与答案为必填项");
                flag = false;
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        private void AddQuestionReset_Click(object sender, EventArgs e)
        {
            this.questionStemTxt.Clear();
            this.questionOptionATxt.Clear();
            this.questionOptionBTxt.Clear();
            this.questionOptionCTxt.Clear();
            this.questionOptionDTxt.Clear();
            this.questionAnswerCbo.SelectedIndex = 0;
        }

        private void questionTypeCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(questionTypeCbo.SelectedIndex == 0)
            {
                AddTxtquestionPanel.Visible = false;
                AddChoicePanel.Visible = true;
            }
            else if(questionTypeCbo.SelectedIndex == 1)
            {
                AddChoicePanel.Visible = false;
                AddTxtquestionPanel.Visible = true;
            }
        }

        private void questionTxtResetBtn_Click(object sender, EventArgs e)
        {
            this.questionStemTxtTxt.Clear();
            this.questionAnswerTxtTxt.Clear();
            
        }

        private void questionTxtSubmitBtn_Click(object sender, EventArgs e)
        {
            string questionType = this.questionTypeCbo.SelectedIndex == 0 ? "choice" : "txt";
            string questionStem = questionStemTxtTxt.Text;
            string questionAnswer = questionAnswerTxtTxt.Text;
            string sqlString = "";
            if (this.Text == "添加题目")
            {
                sqlString = string.Format("INSERT INTO [dbo].[TxtQuestion]([questionType],[questionStem],[questionAnswer])VALUES('{0}','{1}','{2}')", questionType, questionStem, questionAnswer);
            }else if(this.Text == "修改题目")
            {
                sqlString = string.Format(@"UPDATE [dbo].[TxtQuestion]SET [questionType] ='{0}',[questionStem] = '{1}',[questionAnswer] = '{2}' WHERE questionId = {3}",questionType,questionStem,questionAnswer,QuestionModifyFrm.UpdataId.questionTxtId);
            }
            if (InputTxtCheck() && ConnectSql.ChangeData(sqlString))
            {
                MessageBox.Show("提交成功");
                questionTxtResetBtn.PerformClick();
            }
            else
            {
                MessageBox.Show("提交失败");
            }
        }

        private bool InputTxtCheck()
        {
            bool flag = false;
            if (string.IsNullOrEmpty(questionStemTxtTxt.Text))
            {
                flag = false;
            }
            else
            {
                flag = true;
            }
            return flag;
        }
    }
}
