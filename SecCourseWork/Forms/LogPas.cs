using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecCourseWork
{
    public partial class LogPas : Form
    {
        public LogPas()
        {
            InitializeComponent();
            BtnNext.Enabled = false;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            AddClient ac = new AddClient(TB_Login.Text, TB_Password.Text, "admin");         
            ac.ShowDialog();
            Close();
        }

        private void TB_Password_TextChanged(object sender, EventArgs e)
        {
            BtnNext.Enabled = TB_Login.Text.Length != 0 && TB_Password.Text.Length != 0;
        }

        private void TB_Login_TextChanged(object sender, EventArgs e)
        {
            BtnNext.Enabled = TB_Login.Text.Length != 0 && TB_Password.Text.Length != 0;
        }

        private void TB_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) && TB_Login.Text.Length < 20)
                return;
            else
                e.Handled = true;
        }

        private void TB_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) && TB_Password.Text.Length < 20)
                return;
            else
                e.Handled = true;
        }
    }
}
