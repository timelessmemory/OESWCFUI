using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OesUI
{
    public partial class txtfrom : Form
    {
        private string message = "Time  out!";

        public txtfrom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.customTimer1.DoSomething = DoSomeThing;
            this.customTimer1.GetTimer().Enabled = true;
            this.customTimer1.GetTimer().Start();
        }

        public void DoSomeThing()
        {
            MessageBox.Show(message);
        }
    }
}
