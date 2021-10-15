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
    public partial class CorrectQuestionFrm : Skin_VS
    {
        List<string> QuestionId = new List<string>();
        Dictionary<string, string> quest = new Dictionary<string, string>();
        decimal score = 0;
        string paperID;
        string stuID;
        public CorrectQuestionFrm()
        {
            InitializeComponent();
        }

        public CorrectQuestionFrm(string paperId,string stuId)
        {
            InitializeComponent();
            quest = GetQuestion(paperId, stuId);
            questionToFrm(quest);
            this.paperID = paperId;
            this.stuID = stuId;
        }

        private Dictionary<string,string> GetQuestion(string paperId, string stuId)
        {
            string sqlAnswerString = string.Format("SELECT [questionId],[paperAnswer] FROM paperAnswer WHERE paperId = {0} AND stuId= '{1}';", paperId,stuId.Trim());
            DataSet dataSet = ConnectSql.SelectData(sqlAnswerString);
            Dictionary<string, string> question = new Dictionary<string, string>();
            for(int i = 0;i< dataSet.Tables[0].Rows.Count; i++)
            {
                string questionId = dataSet.Tables[0].Rows[i][0].ToString();
                QuestionId.Add(questionId);
                question.Add(questionId, dataSet.Tables[0].Rows[i][1].ToString());
            }
            return question;
        }

        private void questionToFrm(Dictionary<string, string> question)
        {
            if (QuestionId.Count > 0)
            {
                string sqlStemString = string.Format("SELECT [questionStem] FROM TxtQuestion WHERE questionId = {0};", QuestionId[0]);
                DataSet dataSetStem = ConnectSql.SelectData(sqlStemString);
                this.questionStemTxt.Text = dataSetStem.Tables[0].Rows[0][0].ToString();
                this.questionAnswerTxt.Text = question[QuestionId[0]];
                QuestionId.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("当前已是最后一题");
                DialogResult dialog = MessageBox.Show("试卷已完成是否提交", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialog == DialogResult.Yes)
                {
                    String sqlNString = string.Format("SELECT[paperChoiceNum]FROM[ExamSystemDB].[dbo].[paperScore] WHERE[stuId] = '{0}' AND paperId = '{1}'; ", stuID, paperID);
                    int scoreC = Convert.ToInt32(ConnectSql.SelectData(sqlNString).Tables[0].Rows[0][0].ToString());
                    String sqlString = string.Format("UPDATE [dbo].[stuScore] SET [paperScore] = {2} WHERE[stuId] = '{0}' AND [paperId] = {1}; ", stuID,paperID,score+scoreC);
                    if(ConnectSql.ChangeData(sqlString))
                    {
                        this.Close();
                    }
                }
            }
            
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            this.questionStemTxt.Clear();
            this.questionAnswerTxt.Clear();
            submitBtn.Enabled = true;
            questionToFrm(quest);
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            score += this.scoreNup.Value;
            MessageBox.Show("提交成功");
            submitBtn.Enabled = false;
        }
    }
}
