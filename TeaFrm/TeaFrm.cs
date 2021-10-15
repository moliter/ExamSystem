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
    public partial class TeaFrm : Skin_VS
    {
        public TeaFrm()
        {
            InitializeComponent();
        }

        private void QuestionMkBtn_Click(object sender, EventArgs e)
        {
            AddQuestionFrm addQuestionFrm = new AddQuestionFrm();
            addQuestionFrm.MdiParent = this.MdiParent;
            addQuestionFrm.Show();
        }

        private void PaperMkBtn_Click(object sender, EventArgs e)
        {
            PaperMkFrm paperMkFrm = new PaperMkFrm();
            paperMkFrm.MdiParent = this.MdiParent;
            paperMkFrm.Show();
        }

        private void questionModifyBtn_Click(object sender, EventArgs e)
        {
            QuestionModifyFrm questionModifyFrm = new QuestionModifyFrm();
            questionModifyFrm.MdiParent = this.MdiParent;
            questionModifyFrm.Show();
        }

        private void correctPaperBtn_Click(object sender, EventArgs e)
        {
            correctFrm correctFrmR = new correctFrm();
            correctFrmR.MdiParent = this.MdiParent;
            correctFrmR.Show();
        }
    }
}
