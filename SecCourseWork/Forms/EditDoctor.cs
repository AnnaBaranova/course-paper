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
    public partial class EditDoctor : Form
    {
        public int doctId;
        public static string connectionString = "Data Source=TANYA;Initial Catalog=Veterinary clinic;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionString);
        SqlDataAdapter da = new SqlDataAdapter();

        public EditDoctor(int id)
        {
            InitializeComponent();
            BtnSaveDoctor.Enabled = false;
            doctId = id;
            connection.Open();

            SqlCommand ClName = new SqlCommand($@"select Name from Doctor where ID = {doctId}", connection);
            TB_Name.Text = ClName.ExecuteScalar().ToString().Trim(' ');

            SqlCommand ClSurname = new SqlCommand($@"select Surname from Doctor where ID = {doctId}", connection);
            TB_Surname.Text = ClSurname.ExecuteScalar().ToString().Trim(' ');

            SqlCommand ClFathername = new SqlCommand($@"select Fathername from Doctor where ID = {doctId}", connection);
            TB_Fathername.Text = ClFathername.ExecuteScalar().ToString().Trim(' ');

            da = new SqlDataAdapter("select Specialization from Specializ", connection);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            ComBoxSpecializ.DataSource = tbl;
            ComBoxSpecializ.DisplayMember = "Specialization";

            da = new SqlDataAdapter("select Clinic from VetClinic", connection);
            tbl = new DataTable();
            da.Fill(tbl);
            ComBoxClinic.DataSource = tbl;
            ComBoxClinic.DisplayMember = "Clinic";

            connection.Close();
        }

        private void BtnSaveDoctor_Click(object sender, EventArgs e)
        {
            connection.Open();
            string selectedSpec = ((DataRowView)ComBoxSpecializ.SelectedItem).Row.ItemArray[0].ToString().Trim(' ');
            SqlCommand command = new SqlCommand($"select ID from Specializ where Specialization = '{selectedSpec}'", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int SpecId = reader.GetInt32(0);
            reader.Close();

            string selectedClin = ((DataRowView)ComBoxClinic.SelectedItem).Row.ItemArray[0].ToString().Trim(' ');
            command = new SqlCommand($"select ID from VetClinic where Clinic = '{selectedClin}'", connection);
            reader = command.ExecuteReader();
            reader.Read();
            int clinId = reader.GetInt32(0);
            reader.Close();

            string exp = $@"update Doctor set 
                                    Name = '{TB_Name.Text}', 
                                    Surname = '{TB_Surname.Text}', 
                                    Fathername = '{TB_Fathername.Text}', 
                                    ID_Clinic = {clinId}, 
                                    ID_Special ={SpecId}
                            where ID = {doctId}";
            SqlCommand commandDoct = new SqlCommand(exp, connection);
            commandDoct.ExecuteNonQuery();
            connection.Close();
            Close();
        }

        private void TB_ChildTextChanged(object sender, EventArgs e)
        {
            BtnSaveDoctor.Enabled = TB_Name.Text.Length != 0 && TB_Surname.Text.Length != 0 &&
                        TB_Fathername.Text.Length != 0;
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
