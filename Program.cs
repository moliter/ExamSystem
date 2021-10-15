using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExamSystem
{
    public enum FrmFlag
    {
        startTea,startAdm,startStu,noStart
    }
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginUI());
            if (FrmStart.frmFlag == FrmFlag.startTea)
            {
                Application.Run(new TeaFrm.TeaFrm());
            }else if(FrmStart.frmFlag == FrmFlag.startAdm)
            {
                Application.Run(new AdmFrm.AdmFrm());
            }else if(FrmStart.frmFlag == FrmFlag.startStu)
            {
                Application.Run(new StuFrm.StuLogin());
            }
        }
    }

    public static class FrmStart
    {
        public static FrmFlag frmFlag = FrmFlag.noStart;
    }

    public static class account
    {
        public static string id;
    }
}
