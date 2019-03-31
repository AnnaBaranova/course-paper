using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SecCourseWork
{
    public partial class AddClient : Form
    {
        public static string connectionString = "Data Source=TANYA;Initial Catalog=Veterinary clinic;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionString);
        string login, password;
        string who;

        public AddClient(string log, string pas, string Who)
        {
            InitializeComponent();
            BtnSaveClient.Enabled = false;
            login = log;
            password = pas;
            who = Who;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Child_TextChanged(object sender, EventArgs e)
        {
            BtnSaveClient.Enabled = TB_Name.Text.Length != 0 && TB_Surname.Text.Length != 0 &&
                                    TB_Fathername.Text.Length != 0 && TB_PhoneNum.Text.Length != 0 &&  
                                    TB_Email.Text.Length != 0;
        }

        private void TB_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) && TB_Name.Text.Length < 20)
                return;
            else
                e.Handled = true;
        }

        private void TB_Surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) && TB_Surname.Text.Length < 20)
                return;
            else
                e.Handled = true;
        }

        private void TB_Fathername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) && TB_Fathername.Text.Length < 20)
                return;
            else
                e.Handled = true;
        }

        private void TB_PhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && TB_PhoneNum.Text.Length < 15)
                return;
            else
                e.Handled = true;
        }

        private void TB_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TB_Email.Text.Length < 15)
                return;
            else
                e.Handled = true;
        }

        private void BtnSaveClient_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand ClientsCom = new SqlCommand("select max(ID) from Client", connection);
            int ClientNumber = (Int32)ClientsCom.ExecuteScalar();

            string StrCommand = $@"insert into Client (ID, Name, Surname, Fathername, BirthDate, PhoneNumber, Email, Login, Password, ID_Acc)
                                   values ({++ClientNumber}, '{TB_Name.Text}', '{TB_Surname.Text}', '{TB_Fathername.Text}',
                                  '{DTPickerClientBirth.Value}', '{TB_PhoneNum.Text}', '{TB_Email.Text}', '{login}', '{password}', 1)";

            SqlCommand AddCl = new SqlCommand(StrCommand, connection);
            AddCl.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Клиент добавлен!", "Операция добавления", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (who == "user")
            {
                MainForm main = new MainForm(ClientNumber);
                Hide();
                main.Closed += (s, args) => Close();
                main.Show();
            }
            if (who == "admin")
            {
                Close();
            }
        }
    }
}
