using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CCWin;
using System.Threading.Tasks;
using System.Threading;

namespace ExamSystem.StuFrm
{

    public partial class StuExamFrm : Skin_VS
    {
        static DateTime dateTimeStart = DateTime.Now;
        //static DateTime dateTimeFin = dateTimeStart.AddHours(2);
        static DateTime dateTimeFin = dateTimeStart.AddSeconds(20);
        static string stuId = account.id;
        static string answer = null;
        static string type = null;
        static string questionId = null;
        static List<string> choiceList ;
        static List<string> txtList;
        static int score = 0;
        static string PaperId = null;
        static bool closeFrm = false;
        public StuExamFrm()
        {
            InitializeComponent();
        }

        public StuExamFrm(string paperId)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ReadExam(paperId);
            PaperId = paperId;
            //倒计时
            Task t = Task.Factory.StartNew(ExamTimer);
            
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void NextQuestionBtn_Click(object sender, EventArgs e)
        {
            if(this.submitBtn.Enabled == true)
            {
                MessageBox.Show("请先提交");
            }
            else
            {
                this.questionStemTxt.Clear();
                this.questionTxtRtxt.Clear();
                this.choiceATxt.Clear();
                this.choiceBTxt.Clear();
                this.choiceCTxt.Clear();
                this.choiceDTxt.Clear();
                this.choiceA.Checked = false;
                this.choiceB.Checked = false;
                this.choiceC.Checked = false;
                this.choiceD.Checked = false;
                this.choiceA.Enabled = true;
                this.choiceB.Enabled = true;
                this.choiceC.Enabled = true;
                this.choiceD.Enabled = true;
                if (choiceList.Count > 0)
                {
                    ReadChoice();
                }
                else if (txtList.Count > 0)
                {
                    ReadTxt();
                }
                else
                {
                    MessageBox.Show("该题为最后一题");
                    CompleteExam();
                }
                this.submitBtn.Enabled = true;
                this.questionTxtRtxt.Enabled = true;
            }
            

        }
        //读取试卷内容
        private void ReadExam(string paperId)
        {
            string sqlString = string.Format("SELECT [paperChoiceContext],[paperTxtContext] FROM [ExamSystemDB].[dbo].[Paper] WHERE [paperId] = {0};",paperId);
            DataSet dataSetPaper = ConnectSql.SelectData(sqlString);
            choiceList = dataSetPaper.Tables[0].Rows[0][0].ToString().Trim().Split(' ').ToList();
            txtList = dataSetPaper.Tables[0].Rows[0][1].ToString().Trim().Split(' ').ToList();
            if (choiceList.Count > 0)
            {
                ReadChoice();
                
            }else if (txtList.Count > 0)
            {
                ReadTxt();
            }
            dataSetPaper.Dispose();
        }

        //将不同的试卷内容写入框体
        private void ReadChoice()
        {
            
            string i = choiceList[0];
            if(i != "")
            {
                ChoicePanel.Visible = true;
                string sqlChoiceString = string.Format(@"SELECT [questionStem] ,[questionOptionA],[questionOptionB] ,[questionOptionC] ,[questionOptionD] ,[questionAnswer] FROM[ExamSystemDB].[dbo].[ChoiceQuestion] WHERE[questionId] = {0}; ", i);
                answer = questionChoiceToFrm(sqlChoiceString);
                type = "choice";
                questionId = i;
                choiceList.RemoveAt(0);
            }
            else
            {
                CompleteExam();
            }
            
        }

        private void ReadTxt()
        {
            string i = txtList[0];
            if(i != "")
            {
                ChoicePanel.Visible = false;
                questionTxtRtxt.Visible = true;
                string sqlTxtString = string.Format(@"SELECT [questionStem],[questionAnswer] FROM [ExamSystemDB].[dbo].[TxtQuestion] WHERE[questionId] = {0};", i);
                answer = questionTxtToFrm(sqlTxtString);
                type = "txt";
                questionId = i;
                txtList.RemoveAt(0);
            }
            else if (i == null)
            {
                CompleteExam();
            }
            else
            {
                CompleteExam();
            }
        }

        #region 提交试卷
        private void CompleteExam()
        {
            DialogResult dr = MessageBox.Show("试卷以完成，是否提交", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                string sqlString = string.Format("INSERT INTO [dbo].[paperScore]([stuId],[paperId],[paperChoiceNum],[paperTxtNum])VALUES ('{0}',{1},{2},{3})",stuId,PaperId,score,0);
                if (ConnectSql.ChangeData(sqlString))
                {
                    MessageBox.Show("提交成功");
                    exitBtn.PerformClick();
                    closeFrm = true;
                }
            }
            else
            {
                MessageBox.Show("提交失败");
            }
        }
        #endregion

        //把选择题放到框体内
        private string questionChoiceToFrm(string sqlstring)
        {
            DataSet dataset = ConnectSql.SelectData(sqlstring);
            this.questionStemTxt.Text = dataset.Tables[0].Rows[0][0].ToString();
            this.choiceATxt.Text = dataset.Tables[0].Rows[0][1].ToString();
            this.choiceBTxt.Text = dataset.Tables[0].Rows[0][2].ToString();
            this.choiceCTxt.Text = dataset.Tables[0].Rows[0][3].ToString();
            this.choiceDTxt.Text = dataset.Tables[0].Rows[0][4].ToString();
            return dataset.Tables[0].Rows[0][5].ToString();
        }

        //把文本题目放到框体内
        private string questionTxtToFrm(string sqlstring)
        {
            DataSet dataset = ConnectSql.SelectData(sqlstring);
            this.questionStemTxt.Text = dataset.Tables[0].Rows[0][0].ToString();
            return dataset.Tables[0].Rows[0][1].ToString();
        }

        //提交按钮
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if(type == "choice")
            {
                CorrectChoice();
                this.choiceA.Enabled = false;
                this.choiceB.Enabled = false;
                this.choiceC.Enabled = false;
                this.choiceD.Enabled = false;
            }
            if(type == "txt")
            {
                questionTxtRtxt.Visible = true;
                ChoicePanel.Visible = false;
                correctlab.Text = "";
                string txtanswer = this.questionTxtRtxt.Text;
                GetTxt(txtanswer);
                this.questionTxtRtxt.Enabled = false;
            }
        }

        //选择题答案判断
        private void CorrectChoice()
        {
            this.correctlab.Visible = true;
            bool flag = false;
            if ((this.choiceA.Checked == true) && answer.Contains("A")) flag = true;
            if ((this.choiceB.Checked == true) && answer.Contains("B")) flag = true;
            if ((this.choiceC.Checked == true) && answer.Contains("C")) flag = true;
            if ((this.choiceD.Checked == true) && answer.Contains("D")) flag = true;
            if (flag)
            {
                correctlab.Text = "正确";
                correctlab.BackColor = Color.Green;
                score += 1;
            }
            else
            {
                correctlab.Text = "错误";
                correctlab.BackColor = Color.Red;
            }
            this.submitBtn.Enabled = false;
        }

        //把答案写进数据库
        private void GetTxt(string answerString)
        {
            string sqlString = string .Format("INSERT INTO [dbo].[paperAnswer] ([questionId],[paperAnswer],[paperId],[stuId]) VALUES ('{0}','{1}',{2},'{3}');",questionId,answerString,PaperId,stuId);
            ConnectSql.ChangeData(sqlString);
            this.submitBtn.Enabled = false;
        }

        //倒计时
        #region 倒计时
        private void ExamTimer()
        {
            while (true)
            {
                Thread.Sleep(1000);
                TimeSpan time = (dateTimeFin - DateTime.Now);
                this.timeLab.Text = time.ToString().Substring(0, 8);
                if (time.TotalSeconds <= 0)
                {
                    this.timeLab.Text = "00:00:00";
                    SubmitAllQuestion();
                    break;
                }
                    
            }
        }
        #endregion

        #region 强制提交
        private void SubmitAllQuestion()
        {
            //DialogResult dr1 = MessageBox.Show("试卷截止将自动交卷", "提示", MessageBoxButtons.OK,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1,MessageBoxOptions.ServiceNotification);
            Thread.Sleep(2000);
            while (true)
            {
                this.submitBtn.PerformClick();
                this.NextQuestionBtn.PerformClick();
                if (closeFrm)
                    break; 
            }
            
        } 
        #endregion

    }
}
