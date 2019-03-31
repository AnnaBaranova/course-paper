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
    public partial class EnterForm : Form
    {
        public static string connectionString = "Data Source=TANYA;Initial Catalog=Veterinary clinic;Integrated Security=True";
        //public static SqlConnection connection = new SqlConnection(connectionString);
        
        //SqlDataAdapter da;
        //public SqlConnectionStringBuilder builder;
        public int currentUserId;

        public EnterForm()
        {
            InitializeComponent();

            BtnEnter.Enabled = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            string sqlExpression = $@"select ID_Acc, ID
                                   from Client 
                                   where Login = '{TB_Login.Text}'
                                   and Password = '{TB_Password.Text}'";
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, connection);
                DataSet set = new DataSet();
                adapter.Fill(set);
                int accType = int.Parse(set.Tables[0].Rows[0].ItemArray[0].ToString());
                int currentUserId = int.Parse(set.Tables[0].Rows[0].ItemArray[1].ToString());
                connection.Close();
                if (accType == 1) // тип акканунта 1 - простой пользователь
                {
                    MainForm main = new MainForm(currentUserId);
                    Hide();
                    main.Closed += (s, args) => Close();
                    main.Show();
                }
                else // тип аккаунта 2 - администратор
                {
                    Admin admin = new Admin();
                    Hide();
                    admin.Closed += (s, args) => Close();
                    admin.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены неверно" , "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            AddClient AC = new AddClient(TB_Login.Text, TB_Password.Text, "user");
            Hide();
            AC.Closed += (s, args) => Close();
            AC.ShowDialog();
        }

        private void TB_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) && TB_Login.Text.Length < 21)
                return;
            else
                e.Handled = true;
        }

        private void TB_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TB_Password.Text.Length < 21 || e.KeyChar == 8)
                return;
            else
                e.Handled = true;
        }

        private void Child_TextChanged(object sender, EventArgs e)
        {
            BtnEnter.Enabled = TB_Password.Text.Length != 0 && TB_Login.Text.Length != 0;
            BtnAddClient.Enabled = BtnEnter.Enabled;
        }
    }
}
