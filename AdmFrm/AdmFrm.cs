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

namespace ExamSystem.AdmFrm
{
    public partial class AdmFrm : Skin_VS
    {
        public AdmFrm()
        {
            InitializeComponent();
            
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            CreateAddChildForm();

        }

        private void CreateAddChildForm()
        {
            AddUserFrm addUserFrm = new AddUserFrm();
            addUserFrm.MdiParent = this.MdiParent;
            addUserFrm.Show();
        }


        private void selectUserBtn_Click(object sender, EventArgs e)
        {
            SearchUserFrm searchUserFrm = new SearchUserFrm();
            searchUserFrm.MdiParent = this.MdiParent;
            searchUserFrm.Show();
        }


    }
}
