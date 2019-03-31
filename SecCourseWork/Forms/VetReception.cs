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
    public partial class VetReception : Form
    {
        private int userId;
        public static string connectionString = "Data Source=TANYA;Initial Catalog=Veterinary clinic;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionString);
        SqlDataAdapter da;
        public int serviceId, petId;

        public VetReception(int id)
        {
            InitializeComponent();

            userId = id;
            connection.Open();
            da = new SqlDataAdapter($@"select Pet.Name
                                       from Pet, ClientPet 
                                       where {userId} = ClientPet.ID_Client
                                       and ClientPet.ID_Pet = Pet.ID", connection);

            DataTable tbl = new DataTable();
            da.Fill(tbl);
            ComBoxPetName.DataSource = tbl;
            ComBoxPetName.DisplayMember = "Name";

            da = new SqlDataAdapter("select PetService from Service", connection);
            tbl = new DataTable();
            da.Fill(tbl);

            connection.Close();
            ComboBoxService.DataSource = tbl;
            ComboBoxService.DisplayMember = "PetService";
            DTPickerReception.MinDate = new DateTime(2019, 03, 25, 12, 30, 00);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ComboBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            string selectedServ = ((DataRowView)ComboBoxService.SelectedItem).Row.ItemArray[0].ToString().Trim(' ');

            SqlDataAdapter adapter = new SqlDataAdapter($"select Price, ID from Service where PetService = '{selectedServ}'", connection);
            DataSet set = new DataSet();
            adapter.Fill(set);
            TBPrice.Text = set.Tables[0].Rows[0].ItemArray[0].ToString();
            serviceId = int.Parse(set.Tables[0].Rows[0].ItemArray[1].ToString());

            da = new SqlDataAdapter($@"select Doctor.Surname, 
	                                           Doctor.Name, 
	                                           Doctor.Fathername ,
	                                           Specializ.Specialization
                                        from
	                                         Doctor,
	                                         ServiceDoctor,
	                                         Service,
	                                         Specializ
                                        where 
	                                        Doctor.ID_Special = Specializ.ID
	                                        and Doctor.ID = ServiceDoctor.ID_Doctor
	                                        and Service.ID = ServiceDoctor.ID_Service
	                                        and Service.ID = {serviceId}", connection);
            DataTable tableDoct = new DataTable();
            da.Fill(tableDoct);
            List<string> doctors = new List<string>();
            int count = tableDoct.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                doctors.Add(tableDoct.Rows[i].ItemArray[0].ToString().Trim(' ') + " " +
                            tableDoct.Rows[i].ItemArray[1].ToString().Trim(' ') + " " +
                            tableDoct.Rows[i].ItemArray[2].ToString().Trim(' ') + ", " +
                            tableDoct.Rows[i].ItemArray[3].ToString().Trim(' '));
            }
            ComboBoxDoctor.DataSource = doctors;
            connection.Close();
        }

        private void BtnGetReception_Click(object sender, EventArgs e)
        {
            connection.Open();

            string doctorSur = ComboBoxDoctor.Text.Split(' ')[0];
            string doctorNam = ComboBoxDoctor.Text.Split(' ')[1];
            SqlCommand DoctorCom = new SqlCommand($@"select ID from Doctor 
                                                        where Surname = '{doctorSur}'
                                                        and Name = '{doctorNam}'", connection);
            int DoctID = (Int32)DoctorCom.ExecuteScalar();

            SqlCommand PetCom = new SqlCommand($@"select ID from Pet where Name = '{ComBoxPetName.Text.Trim(' ')}'", connection);
            petId = (Int32)PetCom.ExecuteScalar();

            string StrCommand = $@"insert into Reception (ID_Pet, RecTime, ID_Service, EmailNotification, ID_Doctor)
                                   values ({petId}, '{DTPickerReception.Value}', {serviceId}, '{CheckBoxIsNotif.Checked}', {DoctID})";

            SqlCommand AddRec = new SqlCommand(StrCommand, connection);
            AddRec.ExecuteNonQuery();
            connection.Close();
            Close();
        }
    }
}
