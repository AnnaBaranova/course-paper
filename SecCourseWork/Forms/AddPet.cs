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
    public partial class AddPet : Form
    {
        public static string connectionString = "Data Source=TANYA;Initial Catalog=Veterinary clinic;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionString);
        SqlDataAdapter da;
        public int classId, kindId, speciesId, userId;

        public AddPet(int usId)
        {
            userId = usId;
            InitializeComponent();
            BtnAddPet.Enabled = false;
            connection.Open();
            da = new SqlDataAdapter("select PetClass from Class", connection);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            connection.Close();
            ComBoxPetClass.DataSource = tbl;
            ComBoxPetClass.DisplayMember = "PetClass";
        }

        private void PictBoxPet_Click(object sender, EventArgs e)
        {
            Bitmap image;
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);

                    Image result = new Bitmap(226, 290);
                    using (Graphics g = Graphics.FromImage(result))
                    {
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.DrawImage(image, 0, 0, 226, 290);
                        g.Dispose();
                    }

                    PictBoxPet.Size = result.Size;
                    PictBoxPet.Image = result;
                    PictBoxPet.Invalidate();
                }
                catch
                {
                    DialogResult result = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TB_PetName_TextChanged(object sender, EventArgs e)
        {
            BtnAddPet.Enabled = TB_PetName.Text.Length != 0;
        }

        private void TB_PetName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) && TB_PetName.Text.Length < 21)
                return;
            else
                e.Handled = true;
        }

        private void ComBoxPetClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            string selectedClass = ((DataRowView)ComBoxPetClass.SelectedItem).Row.ItemArray[0].ToString().Trim(' ');
            SqlCommand command = new SqlCommand($"select ID from Class where lower(PetClass) like lower('%{selectedClass}%')", connection);
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
            SqlCommand command = new SqlCommand($"select ID from Kind where lower(PetKind) like lower('%{selectedKind}%')", connection);
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

        private void BtnAddPet_Click(object sender, EventArgs e)
        {
            connection.Open();  

            string selectedSpecies = ((DataRowView)ComBoxPetSpecies.SelectedItem).Row.ItemArray[0].ToString().Trim(' ');
            SqlCommand command = new SqlCommand($"select ID from Species where PetSpecies = '{selectedSpecies}'", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            speciesId = reader.GetInt32(0);
            reader.Close();
            
            SqlCommand numPets = new SqlCommand ("select max(ID) from Pet", connection);
            int petsNumber = (Int32)numPets.ExecuteScalar();
            string expPet = $@"INSERT INTO Pet (ID, Name, BirthDate, IsServiced, ID_Species) 
                                      VALUES ({++petsNumber}, '{TB_PetName.Text}', '{DTPickerPet.Value}', '{CheckBoxIsServiced.Checked}', {speciesId})";

            SqlCommand numClPet = new SqlCommand("select max(ID) from ClientPet", connection);

            int ClpetsNumber = (Int32)numClPet.ExecuteScalar();
            string expClPet = $@"INSERT INTO ClientPet (ID, ID_Pet, ID_Client) 
                                values ({++ClpetsNumber}, {petsNumber}, {userId})";
            
            SqlCommand commandPets = new SqlCommand(expPet, connection);
            commandPets.ExecuteNonQuery();
            SqlCommand commandClPet = new SqlCommand(expClPet, connection);
            commandClPet.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Питомец добавлен!", "Операция добавления", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
