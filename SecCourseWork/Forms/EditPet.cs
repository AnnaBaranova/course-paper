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
    public partial class EditPet : Form
    {
        public static string connectionString = "Data Source=TANYA;Initial Catalog=Veterinary clinic;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionString);
        SqlDataAdapter da;
        public int classId, kindId, speciesId, userId, petId;

        public EditPet(int idUs, int idPet)
        {
            InitializeComponent();

            userId = idUs;
            petId = idPet;

            connection.Open();

            SqlCommand petName = new SqlCommand($@"select Name from Pet where ID = {petId}", connection);
            TB_PetName.Text = petName.ExecuteScalar().ToString().Trim(' ');

            SqlCommand petBirth = new SqlCommand($@"select BirthDate from Pet where ID = {petId}", connection);
            DTPickerPetBirth.Value = (DateTime)petBirth.ExecuteScalar();

            SqlCommand petServ = new SqlCommand($@"select IsServiced from Pet where ID = {petId}", connection);
            CheckBoxIsServiced.Checked = (bool)petServ.ExecuteScalar();


            da = new SqlDataAdapter("select PetClass from Class", connection);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            connection.Close();
            ComBoxPetClass.DataSource = tbl;
            ComBoxPetClass.DisplayMember = "PetClass";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RelocatePandaImage(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                PandaImage.Location = new Point(control.Location.X + control.Size.Width + 5, control.Location.Y - 40);
            }
        }

        private void TB_PetName_TextChanged(object sender, EventArgs e)
        {
            BtnSaveEdited.Enabled = TB_PetName.Text.Length != 0;
        }

        private void TB_PetName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) && TB_PetName.Text.Length < 20)
                return;
            else
                e.Handled = true;
        }

        private void ComBoxPetClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            string selectedClass = ((DataRowView)ComBoxPetClass.SelectedItem).Row.ItemArray[0].ToString().Trim(' ');
            SqlCommand command = new SqlCommand($"select ID from Class where PetClass = '{selectedClass}'", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            classId = reader.GetInt32(0);
            reader.Close();
            da = new SqlDataAdapter($@"select PetKind
                                       from Kind
                                       where ID_Class = {classId}", connection);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            connection.Close();
            ComBoxPetKind.DataSource = tbl;
            ComBoxPetKind.DisplayMember = "PetKind";
        }

        private void ComBoxPetKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            string selectedKind = ((DataRowView)ComBoxPetKind.SelectedItem).Row.ItemArray[0].ToString().Trim(' ');
            SqlCommand command = new SqlCommand($"select ID from Kind where PetKind = '{selectedKind}'", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            kindId = reader.GetInt32(0);
            reader.Close();
            da = new SqlDataAdapter($@"select PetSpecies
                                       from Species
                                       where ID_Kind = {kindId}", connection);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            connection.Close();
            ComBoxPetSpecies.DataSource = tbl;
            ComBoxPetSpecies.DisplayMember = "PetSpecies";
        }

        private void ComBoxPetSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            string selectedSpecies = ((DataRowView)ComBoxPetSpecies.SelectedItem).Row.ItemArray[0].ToString().Trim(' ');
            SqlCommand command = new SqlCommand($"select ID from Species where PetSpecies = '{selectedSpecies}'", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            speciesId = reader.GetInt32(0);
            reader.Close();
            connection.Close();
        }

        private void BtnSaveEdited_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand numPets = new SqlCommand("select max(ID) from Pet", connection);
            int petsNumber = (Int32)numPets.ExecuteScalar();
            string expPet = $@"update Pet 
                                set Name = '{TB_PetName.Text}', 
                                    BirthDate = '{DTPickerPetBirth.Value}', 
                                    IsServiced = '{CheckBoxIsServiced.Checked}', 
                                    ID_Species = {speciesId}
                                where ID = {petId}";

            SqlCommand commandPets = new SqlCommand(expPet, connection);
            commandPets.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Данные питомца обновлены!", "Операция редактирования", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
