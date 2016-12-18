using System;
using System.Windows.Forms;
using OesUI.TeacherUI;

namespace OesUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.Run(new TeacherExamListForm());
            //Application.Run(new txtfrom());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm();
            DialogResult result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (loginForm.IsTeacher() == true)
                {
                    Application.Run(new TeacherExamListForm());
                }
                else
                {
                    Application.Run(new FormExamList());
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
