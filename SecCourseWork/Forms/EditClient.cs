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
    public partial class EditClient : Form
    {
        public int userId;
        public static string connectionString = "Data Source=TANYA;Initial Catalog=Veterinary clinic;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionString);

        public EditClient(int id)
        {
            InitializeComponent();
            BtnSaveClient.Enabled = false;
            userId = id;

            connection.Open();

            SqlCommand ClName = new SqlCommand($@"select Name from Client where ID = {userId}", connection);
            TB_Name.Text = ClName.ExecuteScalar().ToString().Trim(' ');

            SqlCommand ClSurname = new SqlCommand($@"select Surname from Client where ID = {userId}", connection);
            TB_Surname.Text = ClSurname.ExecuteScalar().ToString().Trim(' ');

            SqlCommand ClFathername = new SqlCommand($@"select Fathername from Client where ID = {userId}", connection);
            TB_Fathername.Text = ClFathername.ExecuteScalar().ToString().Trim(' ');

            SqlCommand ClBirth = new SqlCommand($@"select BirthDate from Client where ID = {userId}", connection);
            DTPickerClientBirth.Value = (DateTime)ClBirth.ExecuteScalar();

            SqlCommand ClPhone = new SqlCommand($@"select PhoneNumber from Client where ID = {userId}", connection);
            TB_PhoneNum.Text = ClPhone.ExecuteScalar().ToString().Trim(' ');

            SqlCommand ClMail = new SqlCommand($@"select Email from Client where ID = {userId}", connection);
            TB_Email.Text = ClMail.ExecuteScalar().ToString().Trim(' ');

            connection.Close();
        }

        private void BtnSaveClient_Click(object sender, EventArgs e)
        {
            connection.Open();
            string expClient = $@"update Client set 
                                              Name = '{TB_Name.Text}', 
                                              Surname = '{TB_Surname.Text}',
                                              Fathername = '{TB_Fathername.Text}',
                                              BirthDate = '{DTPickerClientBirth.Value}', 
                                              PhoneNumber = '{TB_PhoneNum.Text}', 
                                              Email = '{TB_Email.Text}'
                                where ID = {userId}";

            SqlCommand command = new SqlCommand(expClient, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Данные пользователя обновлены!", "Операция редактирования", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TB_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) && TB_Name.Text.Length < 21)
                return;
            else
                e.Handled = true;
        }

        private void TB_Surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) && TB_Surname.Text.Length < 21)
                return;
            else
                e.Handled = true;
        }

        private void TB_Fathername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) && TB_Fathername.Text.Length < 21)
                return;
            else
                e.Handled = true;
        }

        private void TB_PhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && TB_PhoneNum.Text.Length < 21)
                return;
            else
                e.Handled = true;
        }

        private void TB_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TB_Email.Text.Length < 21)
                return;
            else
                e.Handled = true;
        }

        private void TB_ChildTextChanged(object sender, EventArgs e)
        {
            BtnSaveClient.Enabled = TB_Name.Text.Length != 0 && TB_Surname.Text.Length != 0 &&
                        TB_Fathername.Text.Length != 0 && TB_PhoneNum.Text.Length != 0 &&
                        TB_Email.Text.Length != 0;
        }
    }
}
