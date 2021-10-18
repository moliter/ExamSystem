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
    public partial class PaperMkFrm : Skin_VS
    {
        List<string> questionChoiceNums = new List<string>(); //临时的题库编号表
        List<string> questionTxtNums = new List<string>();    //临时的题库编号表
        List<string> paperTxtNums = new List<string>();       //最终的题库编号表
        List<string> paperChoiceNums = new List<string>();    //最终的题库编号表
        public PaperMkFrm()
        {
            InitializeComponent();
        }

        //搜索
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string questionChoiceStem = this.searchTxt.Text;
            String questionTxtStem = this.searchTxt.Text;
            DataSet dataSetChoice;
            DataSet dataSetTxt;
            if (true)
            {
                AddTxtLv.Items.Clear();
                AddChoiceLv.Items.Clear();
                string sqlChoiceString = string.Format("SELECT [questionId],[questionType],[questionStem],[questionOptionA],[questionOptionB],[questionOptionC],[questionOptionD],[questionAnswer],[questionId]FROM[dbo].[ChoiceQuestion] WHERE [questionStem] LIKE '%{0}%';; ", questionChoiceStem);
                string sqlTxtString = string.Format("SELECT [questionId],[questionType],[questionStem],[questionAnswer],[questionId]FROM[dbo].[TxtQuestion] WHERE[questionStem] LIKE '%{0}%'; ", questionTxtStem);
                dataSetChoice = ConnectSql.SelectData(sqlChoiceString);
                dataSetTxt = ConnectSql.SelectData(sqlTxtString);
                ChoiceLv(dataSetChoice);
                TxtLv(dataSetTxt);
            }
        }

        //搜索输入检测
        private bool InputSearchCheck()
        {
            bool flag = false;
            if (string.IsNullOrEmpty(searchTxt.Text)){
                flag = false;
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        //选择题获取数据
        private bool ChoiceLv(DataSet dataSet)
        {
            bool flag = false;
            for(int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                if (!questionChoiceNums.Contains(dataSet.Tables[0].Rows[i][0].ToString().Trim()))
                {
                    ListViewItem listViewItem = new ListViewItem(dataSet.Tables[0].Rows[i][0].ToString().Trim());
                    for (int j = 1; j < dataSet.Tables[0].Columns.Count; j++)
                    {
                        listViewItem.SubItems.Add(dataSet.Tables[0].Rows[i][j].ToString().Trim());
                    }
                    AddChoiceLv.Items.Add(listViewItem);
                    flag = true;
                }
            }
            if (dataSet.Tables[0].Rows.Count<=0) { flag = true; }
            dataSet.Dispose();
            return flag;
        }

        //文本题获取数据
        private bool TxtLv(DataSet dataSet)
        {
            bool flag = false;
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                if (!questionTxtNums.Contains(dataSet.Tables[0].Rows[i][0].ToString().Trim()))
                {
                    ListViewItem listViewItem = new ListViewItem(dataSet.Tables[0].Rows[i][0].ToString().Trim());
                    for (int j = 1; j < dataSet.Tables[0].Columns.Count; j++)
                    {
                        listViewItem.SubItems.Add(dataSet.Tables[0].Rows[i][j].ToString().Trim());
                    }
                    AddTxtLv.Items.Add(listViewItem);
                    flag = true;
                }
            }
            if (dataSet.Tables[0].Rows.Count <= 0) { flag = true; }
            dataSet.Dispose();
            return flag;
        }

        //所有选择题选中
        private void AllSelectBtn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < AddChoiceLv.Items.Count; i++)
            {
                AddChoiceLv.Items[i].Checked = true;
                
            }
        }

        //所有文本题选中并添加到试卷
        private void AllSelectTxtBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AddTxtLv.Items.Count; i++)
            {
                AddTxtLv.Items[i].Checked = true;
                
            }
        }

        //把选中的问题提到试卷
        private bool QuestionToPaper()
        {
            bool flag = false;
            for(int i=0; i< AddChoiceLv.Items.Count; i++)
            {
                if (AddChoiceLv.Items[i].Checked == true && !questionChoiceNums.Contains(AddChoiceLv.Items[i].SubItems[0].Text))
                {
                    questionChoiceNums.Add(AddChoiceLv.Items[i].SubItems[0].Text);
                }
                flag = true;
            }
            for (int i = 0; i < AddTxtLv.Items.Count; i++)
            {
                if (AddTxtLv.Items[i].Checked == true && !questionTxtNums.Contains(AddTxtLv.Items[i].SubItems[0].Text))
                {
                    questionTxtNums.Add(AddTxtLv.Items[i].SubItems[0].Text);
                }
                flag = true;
            }
            return flag;
        }

        //添加按钮
        
        private void AddBtn_Click(object sender, EventArgs e)
        {
            
            if (QuestionToPaper())
            {
                foreach (string i in questionChoiceNums)
                {
                    if (!paperChoiceNums.Contains(i))
                    {
                        string sqlString = string.Format("SELECT [questionId],[questionType],[questionStem],[questionOptionA],[questionOptionB],[questionOptionC],[questionOptionD],[questionAnswer]FROM[dbo].[ChoiceQuestion] WHERE questionId = {0}; ", i);
                        DataSet dataSet = ConnectSql.SelectData(sqlString);
                        ListViewItem listViewItem = new ListViewItem(i.ToString());
                        for (int j = 1; j < dataSet.Tables[0].Columns.Count; j++)
                        {
                            listViewItem.SubItems.Add(dataSet.Tables[0].Rows[0][j].ToString().Trim());
                        }
                        PaperChoiceLv.Items.Add(listViewItem);
                        dataSet.Dispose();                        
                        paperChoiceNums.Add(i);
                    }
                }
                foreach (string i in questionTxtNums)
                {
                    if (!paperTxtNums.Contains(i))
                    {
                        string sqlString = string.Format("SELECT [questionId],[questionType],[questionStem],[questionAnswer]FROM[dbo].[TxtQuestion] WHERE questionId = {0}; ", i);
                        DataSet dataSet = ConnectSql.SelectData(sqlString);
                        ListViewItem listViewItem = new ListViewItem(i.ToString());
                        for (int j = 1; j < dataSet.Tables[0].Columns.Count; j++)
                        {
                            listViewItem.SubItems.Add(dataSet.Tables[0].Rows[0][j].ToString().Trim());
                        }
                        PaperTxtLv.Items.Add(listViewItem);
                        dataSet.Dispose();
                        paperTxtNums.Add(i);
                    }
                }
            }
            searchBtn.PerformClick();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PaperChoiceLv.Items.Count; i++)
            {
                if (PaperChoiceLv.Items[i].Checked == true && paperChoiceNums.Contains(PaperChoiceLv.Items[i].SubItems[0].Text.Trim())){
                    paperChoiceNums.Remove(PaperChoiceLv.Items[i].SubItems[0].Text);
                    questionChoiceNums.Remove(PaperChoiceLv.Items[i].SubItems[0].Text);
                    PaperChoiceLv.Items.Remove(PaperChoiceLv.Items[i]);
                    i--;
                }
            }
            //foreach(int i in k1)
            //{
            //    PaperChoiceLv.Items.Remove(PaperChoiceLv.Items[i]);

            //}
            
            for (int i = 0; i < PaperTxtLv.Items.Count; i++)
            {
                if (PaperTxtLv.Items[i].Checked == true && paperTxtNums.Contains(PaperTxtLv.Items[i].SubItems[0].Text.Trim()))
                {
                    paperTxtNums.Remove(PaperTxtLv.Items[i].SubItems[0].Text);
                    questionTxtNums.Remove(PaperTxtLv.Items[i].SubItems[0].Text);
                    PaperTxtLv.Items.Remove(PaperTxtLv.Items[i]);
                    i--;
                }
            }
            searchBtn.PerformClick();
        }

        private void PaperSubmit_Click(object sender, EventArgs e)
        {
            string paperClass = this.paperClassCbo.Text;
            string paperChoiceContext = "";
            foreach(string i in paperChoiceNums)
            {
                paperChoiceContext += i;
                paperChoiceContext += " ";
            }
            string paperStatus = "T";
            string paperTxtContext = "";
            foreach(string i in paperTxtNums)
            {
                paperTxtContext += i;
                paperTxtContext += " ";
            }
            string paperName = this.PaperNameTxt.Text;
            string sqlConnect = string.Format("INSERT INTO [dbo].[Paper] ([paperClass],[paperChoiceContext],[paperStatus],[paperTxtContext],[paperName])VALUES('{0}','{1}','{2}','{3}','{4}');",paperClass.Trim(),paperChoiceContext,paperStatus,paperTxtContext,paperName);
            if (checkMkPaper()) {
                if (ConnectSql.ChangeData(sqlConnect))
                {
                    string sqlString = string.Format("SELECT [userNum],[userClass] FROM [ExamSystemDB].[dbo].[User] WHERE [userClass] = '{0}';", paperClass);
                    string sqlPstring = string.Format("SELECT [paperId] FROM [dbo].[Paper] WHERE [paperName]='{0}'", paperName);
                    DataSet dataSetStu = ConnectSql.SelectData(sqlString);
                    string paperId = ConnectSql.SelectData(sqlPstring).Tables[0].Rows[0][0].ToString();
                    try
                    {
                        for (int i = 0; i < dataSetStu.Tables[0].Rows.Count; i++)
                        {
                            string s = dataSetStu.Tables[0].Rows[i][0].ToString().Trim();
                            ConnectSql.ChangeData(string.Format("INSERT INTO [stuScore] VALUES ('{0}','{1}',{2},{3});", s, paperClass, paperId, -1));
                        }
                    }
                    catch (Exception sqle)
                    {
                        throw (sqle);
                    }
                    dataSetStu.Dispose();
                    MessageBox.Show("试卷生成成功");
                    AddChoiceLv.Clear();
                    AddTxtLv.Clear();
                    PaperChoiceLv.Clear();
                    PaperTxtLv.Clear();
                    questionChoiceNums.Clear();
                    questionTxtNums.Clear();
                    paperChoiceNums.Clear();
                    paperTxtNums.Clear();
                    PaperNameTxt.Clear();
                }
                else
                {
                    MessageBox.Show("试卷生成失败");
                }
            }
            
        }

        private bool checkMkPaper(){
            bool flag = false;
            if (this.paperClassCbo.SelectedIndex == 0) {
                MessageBox.Show("请选择班级！");
                flag = false;
            }else{
                flag = true;
            }
            return flag;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (choiceNup.Value > 0 && AddChoiceLv.Items.Count>0)
            {
                randomChoice();
            }
            if(txtNup.Value > 0 && AddTxtLv.Items.Count>0)
            {
                randomTxt();
            }
            AddBtn.PerformClick();

        }

        private void randomChoice()
        {
            RandomOption(AddChoiceLv, Convert.ToInt32(choiceNup.Value));
        }

        private void randomTxt() 
        {
            RandomOption(AddTxtLv, Convert.ToInt32(txtNup.Value));
        }

        private void RandomOption(ListView listView,int questionCount)
        {
            Random random = new Random(); 
            for(int i = questionCount; i > 0; i--)
            {
                int r = random.Next(0, listView.Items.Count);
                listView.Items[r].Checked = true;
            }
        }
    }
}
