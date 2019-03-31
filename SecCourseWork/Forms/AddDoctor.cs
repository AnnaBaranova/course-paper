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
    public partial class AddDoctor : Form
    {
        public static string connectionString = "Data Source=TANYA;Initial Catalog=Veterinary clinic;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionString);
        SqlDataAdapter da = new SqlDataAdapter();

        public AddDoctor()
        {
            InitializeComponent();
            BtnSaveDoctor.Enabled = false;
            connection.Open();
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

            string exp = $@"INSERT INTO Doctor (Name, Surname, Fathername, ID_Clinic, ID_Special) 
                                      VALUES ('{TB_Name.Text}', '{TB_Surname.Text}', '{TB_Fathername.Text}', {clinId}, {SpecId})";

            SqlCommand commandDoct = new SqlCommand(exp, connection);
            commandDoct.ExecuteNonQuery();
            connection.Close();
            Close();
        }

        private void TB_ChildTextChanged(object sender, EventArgs e)
        {
            BtnSaveDoctor.Enabled = TB_Name.Text.Length != 0 && TB_Surname.Text.Length != 0 
                                        && TB_Fathername.Text.Length != 0;
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
    }
}
