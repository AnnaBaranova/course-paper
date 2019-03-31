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
using System.Reflection;
using excel = Microsoft.Office.Interop.Excel;

namespace SecCourseWork
{
    public partial class Admin : Form
    {
        public static string connectionString = "Data Source=TANYA;Initial Catalog=Veterinary clinic;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionString);
        SqlDataAdapter da = new SqlDataAdapter();
        string curTable;

        public Admin()
        {
            InitializeComponent();
            BlockButtons();
        }

        private void BlockButtons()
        {
            BtnAddClient.Enabled = false;
            BtnEditClient.Enabled = false;
            BtnDeleteClient.Enabled = false;
            BtnAddPet.Enabled = false;
            BtnEditPet.Enabled = false;
            BtnDeletePet.Enabled = false;
            BtnAddDoctor.Enabled = false;
            BtnEditDoctor.Enabled = false;
            BtnDeleteDoctor.Enabled = false;
            BtnExcel.Enabled = false;
        }

        private void ShowClients()
        {
            DataTable AdmTable = new DataTable();

            da = new SqlDataAdapter(@"select ID as 'Номер',
                                            Name as 'Имя', 
                                            Surname as 'Фамилия', 
                                            Fathername as 'Отчество', 
                                            BirthDate as 'Дата рождения', 
                                            PhoneNumber as 'Номер телефона',
                                            Email as 'Эл. почта', 
                                            Login as 'Логин', 
                                            Password as 'Пароль' 
                                    from Client", connection);
            da.Fill(AdmTable);
            DGWAdmData.DataSource = AdmTable;
        }

        private void ShowPets()
        {
            DataTable AdmTable = new DataTable();

            da = new SqlDataAdapter(@"select Client.ID as 'Номер пользователя',
                                        Client.Name as 'Имя пользователя',
                                        Pet.Name as 'Кличка питомца',
                                        Pet.BirthDate as 'Дата рождения питомца',
                                        Pet.IsServiced as 'Статус обслуживания',
                                        Class.PetClass as 'Класс',
                                        Kind.PetKind as 'Род',
                                        Species.PetSpecies as 'Порода'
                                    from Client,
                                        ClientPet,
                                        Pet,
                                        Species,
                                        Kind,
                                        Class
                                    where Client.ID = ClientPet.ID_Client
                                          and ClientPet.ID_Pet = Pet.ID
                                          and Pet.ID_Species = Species.ID
                                          and Species.ID_Kind = Kind.ID
                                          and Kind.ID_Class = Class.ID", connection);
            da.Fill(AdmTable);
            DGWAdmData.DataSource = AdmTable;
        }

        private void ShowDoctors()
        {
            DataTable AdmTable = new DataTable();
            da = new SqlDataAdapter(@"select Doctor.ID AS 'Номер', 
                                    Doctor.Name as 'Имя', 
                                    Doctor.Surname as 'Фамилия', 
                                    Doctor.Fathername as 'Отчество', 
                                    VetClinic.Clinic as 'Вет. клиника', 
                                    VetClinic.Address as 'Адрес клиники',
                                    Specializ.Specialization as 'Специализация' 
                                from  Doctor,
                                    VetClinic,
                                    Specializ
                                where Doctor.ID_Clinic = VetClinic.ID
                                and Doctor.ID_Special = Specializ.ID",
                                    connection);
            da.Fill(AdmTable);
            DGWAdmData.DataSource = AdmTable;
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            BlockButtons();
            ShowClients();
            BtnAddClient.Enabled = true;
            BtnEditClient.Enabled = true;
            BtnDeleteClient.Enabled = true;
            BtnExcel.Enabled = true;
            curTable = "Client";
        }

        private void BtnPets_Click(object sender, EventArgs e)
        {
            BlockButtons();
            ShowPets();
            BtnAddPet.Enabled = true;
            BtnEditPet.Enabled = true;
            BtnDeletePet.Enabled = true;
            BtnExcel.Enabled = true;
            curTable = "Pet";
        }

        private void BtnDoctors_Click(object sender, EventArgs e)
        {
            BlockButtons();
            ShowDoctors();
            BtnAddDoctor.Enabled = true;
            BtnEditDoctor.Enabled = true;
            BtnDeleteDoctor.Enabled = true;
            BtnExcel.Enabled = true;
            curTable = "Doctor";
        }

        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            LogPas lp = new LogPas();
            lp.ShowDialog();
            ShowClients();
        }

        private void BtnEditClient_Click(object sender, EventArgs e)
        {
            int userId = (Int32)((DGWAdmData.SelectedRows[0].Cells[0]).Value);
            EditClient EC = new EditClient(userId);
            EC.ShowDialog();
            ShowClients();
        }

        private void BtnDeleteClient_Click(object sender, EventArgs e)
        {
            int userId = (Int32)((DGWAdmData.SelectedRows[0].Cells[0]).Value);
            if (userId == 1)
            {
                MessageBox.Show("Невозможно удалить профиль администратора!", "Операция удаления",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<int> idPets = new List<int>();
            connection.Open();
            SqlCommand command = new SqlCommand($@"select ID_Pet
                                                    from ClientPet
                                                    where ClientPet.ID_Client = {userId}", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                idPets.Add(reader.GetInt32(0));
            }
            reader.Close();
            for(int i = 0; i < idPets.Count; i++)
            {
                SqlCommand commandClPet = new SqlCommand($"delete from ClientPet where ID_Pet = {idPets[i]}", connection);
                commandClPet.ExecuteNonQuery();

                SqlCommand commandRec = new SqlCommand($"delete from Reception where ID_Pet = {idPets[i]}", connection);
                commandClPet.ExecuteNonQuery();

                SqlCommand commandPet = new SqlCommand($"delete from Pet where ID = {idPets[i]}", connection);
                commandPet.ExecuteNonQuery();
            }

            SqlCommand commandUser = new SqlCommand($"delete from Client where ID = {userId}", connection);
            commandUser.ExecuteNonQuery();

            MessageBox.Show("Клиент удален!", "Операция удаления", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
            ShowClients();
        }

        private void BtnAddPet_Click(object sender, EventArgs e)
        {
            int userId = (Int32)((DGWAdmData.SelectedRows[0].Cells[0]).Value);
            AddPet ap = new AddPet(userId);
            ap.ShowDialog();
            ShowPets();
        }

        private void BtnEditPet_Click(object sender, EventArgs e)
        {
            int userId = (Int32)((DGWAdmData.SelectedRows[0].Cells[0]).Value);
            string PetName = ((DGWAdmData.SelectedRows[0].Cells[2]).Value).ToString().Trim(' ');
            connection.Open();
            SqlCommand command = new SqlCommand($"select ID from Pet where Name = '{PetName}'", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int petId = reader.GetInt32(0);
            reader.Close();
            connection.Close();
            EditPet EP = new EditPet(userId, petId);
            EP.ShowDialog();
            ShowPets();
        }

        private void BtnDeletePet_Click(object sender, EventArgs e)
        {
            int userId = (Int32)((DGWAdmData.SelectedRows[0].Cells[0]).Value);
            string PetName = ((DGWAdmData.SelectedRows[0].Cells[2]).Value).ToString().Trim(' ');
            connection.Open();
            SqlCommand command = new SqlCommand($"select ID from Pet where Name = '{PetName}'", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int petId = reader.GetInt32(0);
            reader.Close();

            SqlCommand commandClPet = new SqlCommand($"delete from ClientPet where ID_Pet = {petId}", connection);
            commandClPet.ExecuteNonQuery();

            SqlCommand commandRec = new SqlCommand($"delete from Reception where ID_Pet = {petId}", connection);
            commandClPet.ExecuteNonQuery();

            SqlCommand commandPet = new SqlCommand($"delete from Pet where ID = {petId}", connection);
            commandPet.ExecuteNonQuery();

            MessageBox.Show("Питомец удален!", "Операция удаления", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();

            ShowPets();
        }

        private void BtnAddDoctor_Click(object sender, EventArgs e)
        {
            AddDoctor ad = new AddDoctor();
            ad.ShowDialog();
            ShowDoctors();
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
                worksheet.Name = curTable + "s";

                for (int i = 1; i < DGWAdmData.RowCount + 1; i++)
                {
                    for (int j = 1; j < DGWAdmData.ColumnCount + 1; j++)
                        worksheet.Rows[i].Columns[j] = DGWAdmData.Rows[i - 1].Cells[j - 1].Value;
                }

                exApp.AlertBeforeOverwriting = false;
                workbook.SaveAs(path);
                exApp.Quit();

                MessageBox.Show("Таблица успешно сохранена!", "Операция сохранения",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TB_Search_TextChanged(object sender, EventArgs e)
        {
            //0 - по фамилии клиента
            // 1 - по имени питомца
            // 2 - по фамилии врача
            switch (CBWhereSearch.SelectedIndex)
            {
                case 0:
                    DataTable AdmTable0 = new DataTable();
                    SqlDataAdapter da0 = new SqlDataAdapter($@"select ID as 'Номер',
                                                        Name as 'Имя', 
                                                        Surname as 'Фамилия', 
                                                        Fathername as 'Отчество', 
                                                        BirthDate as 'Дата рождения', 
                                                        PhoneNumber as 'Номер телефона',
                                                        Email as 'Эл. почта', 
                                                        Login as 'Логин', 
                                                        Password as 'Пароль' 
                                                from Client where lower(Surname) like lower ('%{TB_Search.Text.Trim(' ')}%')", connection);
                    da0.Fill(AdmTable0);
                    DGWAdmData.DataSource = AdmTable0;
                    break;
                case 1:
                    DataTable AdmTable1 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter($@"select Client.ID as 'Номер пользователя',
                                                        Client.Name as 'Имя пользователя',
                                                        Pet.Name as 'Кличка питомца',
                                                        Pet.BirthDate as 'Дата рождения питомца',
                                                        Pet.IsServiced as 'Статус обслуживания',
                                                        Class.PetClass as 'Класс',
                                                        Kind.PetKind as 'Род',
                                                        Species.PetSpecies as 'Порода'
                                                    from Client,
                                                        ClientPet,
                                                        Pet,
                                                        Species,
                                                        Kind,
                                                        Class
                                                    where Client.ID = ClientPet.ID_Client
                                                          and ClientPet.ID_Pet = Pet.ID
                                                          and Pet.ID_Species = Species.ID
                                                          and Species.ID_Kind = Kind.ID
                                                          and Kind.ID_Class = Class.ID
                                                          and lower(Pet.Name) like lower ('%{TB_Search.Text.Trim(' ')}%')", connection);
                    da1.Fill(AdmTable1);
                    DGWAdmData.DataSource = AdmTable1;
                    break;
                case 2:
                    DataTable AdmTable2 = new DataTable();
                    SqlDataAdapter da2 = new SqlDataAdapter($@"select Doctor.ID AS 'Номер', 
                                                                    Doctor.Name as 'Имя', 
                                                                    Doctor.Surname as 'Фамилия', 
                                                                    Doctor.Fathername as 'Отчество', 
                                                                    VetClinic.Clinic as 'Вет. клиника', 
                                                                    VetClinic.Address as 'Адрес клиники',
                                                                    Specializ.Specialization as 'Специализация' 
                                                                from  Doctor,
                                                                      VetClinic,
                                                                      Specializ
                                                                where Doctor.ID_Clinic = VetClinic.ID
                                                                and Doctor.ID_Special = Specializ.ID
                                                                and lower(Doctor.Surname) like lower ('%{TB_Search.Text.Trim(' ')}%')",
                                                                            connection);
                    da2.Fill(AdmTable2);
                    DGWAdmData.DataSource = AdmTable2;
                    break;
            }
        }

        private void BtnReceptions_Click(object sender, EventArgs e)
        {
            BlockButtons();
            DataTable AdmTable = new DataTable();
            da = new SqlDataAdapter($@"select 
                                        Client.Surname as 'Фамилия клиента',
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
	                                    Client,
	                                    Service,
	                                    Doctor,
	                                    VetClinic
                                    where
	                                    Reception.ID_Pet = Pet.ID
	                                    and ClientPet.ID_Pet = Pet.ID
	                                    and ClientPet.ID_Client = Client.ID
	                                    and Reception.ID_Service = Service.ID
	                                    and Reception.ID_Doctor = Doctor.ID
	                                    and Doctor.ID_Clinic = VetClinic.ID", connection);
            da.Fill(AdmTable);
            DGWAdmData.DataSource = AdmTable;
        }

        private void BtnEditDoctor_Click(object sender, EventArgs e)
        {
            int Id = (Int32)((DGWAdmData.SelectedRows[0].Cells[0]).Value);

            EditDoctor ed = new EditDoctor(Id);
            ed.ShowDialog();
            ShowDoctors();
        }

        private void BtnDeleteDoctor_Click(object sender, EventArgs e)
        {
            int Id = (Int32)((DGWAdmData.SelectedRows[0].Cells[0]).Value);
            connection.Open();

            SqlCommand commandRec = new SqlCommand($"delete from Reception where ID_Doctor = {Id}", connection);
            commandRec.ExecuteNonQuery();

            SqlCommand commandServ = new SqlCommand($"delete from ServiceDoctor where ID_Doctor = {Id}", connection);
            commandServ.ExecuteNonQuery();

            SqlCommand commandDoc = new SqlCommand($"delete from Doctor where ID = {Id}", connection);
            commandDoc.ExecuteNonQuery();

            connection.Close();
            ShowDoctors();
        }
    }
}
