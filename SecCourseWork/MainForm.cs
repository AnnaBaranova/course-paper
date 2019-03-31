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
using excel = Microsoft.Office.Interop.Excel;

namespace SecCourseWork
{
    public partial class MainForm : Form
    {
        Random rnd = new Random();
        private int userId;
        private int petId = 0;

        public static string connectionString = "Data Source=TANYA;Initial Catalog=Veterinary clinic;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionString);
        SqlDataAdapter da;
        DataTable ClientTable = new DataTable();
        DataTable RecTable = new DataTable();

        public MainForm(int id)
        {
            InitializeComponent();
            userId = id;
            BtnDeletePet.Enabled = false;
            BtnEditPet.Enabled = false;
        }

        private void BtnAddPet_Click(object sender, EventArgs e)
        {
            AddPet AP = new AddPet(userId);
            AP.ShowDialog();
            ShowPets();
        }

        private void BtnEditPet_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedName = (DGWPets.SelectedRows[0].Cells[0]).Value.ToString().Trim(' ');
                connection.Open();
                SqlCommand command = new SqlCommand($"select ID from Pet where Name = '{selectedName}'", connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                petId = reader.GetInt32(0);
                reader.Close();
                connection.Close();
                EditPet EP = new EditPet(userId, petId);
                EP.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Сначала необходимо добавить питомца", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ShowPets();
        }

        private void BtnDeletePet_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedName = (DGWPets.SelectedRows[0].Cells[0]).Value.ToString().Trim(' ');
                connection.Open();
                SqlCommand command = new SqlCommand($"select ID from Pet where Name = '{selectedName}'", connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                petId = reader.GetInt32(0);
                reader.Close();

                SqlCommand commandClPet = new SqlCommand($"delete from ClientPet where ID_Pet = {petId}", connection);
                commandClPet.ExecuteNonQuery();

                SqlCommand commandRec = new SqlCommand($"delete from Reception where ID_Pet = {petId}", connection);
                commandRec.ExecuteNonQuery();

                SqlCommand commandPet = new SqlCommand($"delete from Pet where ID = {petId}", connection);
                commandPet.ExecuteNonQuery();

                MessageBox.Show("Питомец удален!", "Операция удаления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Сначала необходимо выбрать питомца", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ShowPets();
            ShowReceptions();
        }

        private void ShowPets()
        {
            ClientTable.Clear();
            DGWPets.DataSource = ClientTable;
            da = new SqlDataAdapter($@"select 
                                    Pet.Name as 'Кличка питомца',
                                    Pet.BirthDate as 'Дата рождения питомца',
                                    Pet.IsServiced as 'Статус обслуживания',
                                    Class.PetClass as 'Класс',
                                    Kind.PetKind as 'Род',
                                    Species.PetSpecies as 'Порода'
                                from ClientPet,
                                    Pet,
                                    Species,
                                    Kind,
                                    Class
                                where {userId} = ClientPet.ID_Client
                                  and ClientPet.ID_Pet = Pet.ID
                                  and Pet.ID_Species = Species.ID
                                  and Species.ID_Kind = Kind.ID
                                  and Kind.ID_Class = Class.ID", connection);
            da.Fill(ClientTable);
            DGWPets.DataSource = ClientTable;
        }

        private void BtnShowPets_Click(object sender, EventArgs e)
        {
            ShowPets();
            BtnEditPet.Enabled = true;
            BtnDeletePet.Enabled = true;
        }

        private void BtnReception_Click(object sender, EventArgs e)
        {
            int hehe = rnd.Next(0, 5);
            if (hehe == 3)
                MessageBox.Show("Женщинаа, вы не видите, у нас обед вообще-то.", "Закрыто", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                VetReception VR = new VetReception(userId);
                VR.ShowDialog();
                ShowReceptions();
            }
        }

        private void BtnEditClient_Click(object sender, EventArgs e)
        {
            EditClient EC = new EditClient(userId);
            EC.ShowDialog();
        }

        private void ShowReceptions()
        {
            RecTable.Clear();
            DgwReceptions.DataSource = ClientTable;
            da = new SqlDataAdapter($@"select 
	                                        Pet.Name as 'Имя питомца',
	                                        Service.PetService as 'Услуга',
	                                        Reception.RecTime as 'Время записи',
	                                        Service.Price as 'Стоимость',
	                                        Doctor.Surname as 'Фамилия врача',
	                                        Doctor.Name as 'Имя врача',
	                                        VetClinic.Clinic as 'Название клиники',
	                                        VetClinic.Address as 'Адрес клиники'
                                        from
	                                        Reception,
	                                        Pet,
	                                        ClientPet,
	                                        Service,
	                                        Doctor,
	                                        VetClinic
                                        where
	                                        Reception.ID_Pet = Pet.ID
	                                        and ClientPet.ID_Pet = Pet.ID
	                                        and ClientPet.ID_Client = {userId}
	                                        and Reception.ID_Service = Service.ID
	                                        and Reception.ID_Doctor = Doctor.ID
	                                        and Doctor.ID_Clinic = VetClinic.ID;", connection);
            da.Fill(RecTable);
            DgwReceptions.DataSource = RecTable;
        }

        private void BtnMyReceptions_Click(object sender, EventArgs e)
        {
            ShowReceptions();
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создайте новый файл или выберите существующий для перезаписи", "Новый файл",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Открытие файла",
                Filter = "Excel (*.xlsx)|*xlsx| Все файлы (*.*)|(*.*)",
                AddExtension = true
            };

            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                string path = sfd.FileName;
                excel.Application exApp = new excel.Application();
                excel.Workbook workbook = exApp.Workbooks.Add();
                excel.Worksheet worksheet = workbook.ActiveSheet;
                worksheet.Name = "Питомцы";

                for (int i = 1; i < DGWPets.RowCount + 1; i++)
                {
                    for (int j = 1; j < DGWPets.ColumnCount + 1; j++)
                        worksheet.Rows[i].Columns[j] = DGWPets.Rows[i - 1].Cells[j - 1].Value;
                }

                var xlSheets = workbook.Sheets as excel.Sheets;
                var xlNewSheet = (excel.Worksheet)xlSheets.Add(xlSheets[1], Type.Missing, Type.Missing, Type.Missing);
                xlNewSheet.Name = "Записи";

                for (int i = 1; i < DgwReceptions.RowCount + 1; i++)
                {
                    for (int j = 1; j < DgwReceptions.ColumnCount + 1; j++)
                        xlNewSheet.Rows[i].Columns[j] = DgwReceptions.Rows[i - 1].Cells[j - 1].Value;
                }

                exApp.AlertBeforeOverwriting = false;
                workbook.SaveAs(path);
                exApp.Quit();

                MessageBox.Show("Таблица успешно сохранена!", "Операция сохранения",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BtnDeleteReception_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedPet = (DgwReceptions.SelectedRows[0].Cells[0]).Value.ToString().Trim(' ');
                connection.Open();
                SqlCommand command = new SqlCommand($@"select Reception.ID 
                                                            from
                                                                Reception,
                                                                Pet
                                                            where Reception.ID_Pet = Pet.ID
                                                            and Pet.Name = '{selectedPet}'", connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                int recId = reader.GetInt32(0);
                reader.Close();

                SqlCommand commandRec = new SqlCommand($"delete from Reception where ID = {recId}", connection);
                commandRec.ExecuteNonQuery();

                MessageBox.Show("Запись удалена!", "Операция удаления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception)
            {  }

            ShowReceptions();
        }
    }
}