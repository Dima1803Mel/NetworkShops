using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NetworkShops
{
    public partial class LoginForm : Form
    {
        string sql = "Server=localhost;Port=5432;Database=course_project; User id = postgres; Password = totalWar1234;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = LoginField.Text;
            String password = PassField.Text;
            String role = CheckRole(login, password);
            int idShop = Convert.ToInt32(LoadIdShop(login, password));
            switch (role)
            {
                case "продавец":
                    this.Hide();
                    Assistant assistant = new Assistant(idShop);
                    assistant.Show();
                    break;
                case "директор сети магазинов":
                    this.Hide();
                    DirectorNetworkShops directorNetworkShops = new DirectorNetworkShops();
                    directorNetworkShops.Show();
                    break;
                case "директор магазина":
                    this.Hide();
                    DirectorShop director = new DirectorShop();
                    director.Show();
                    break;
                case "кадровик":
                    this.Hide();
                    KadrovikForm kadrovikForm = new KadrovikForm();
                    kadrovikForm.Show();
                    break;
            }
            //this.Close();
        }

        private void TextLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private string CheckRole(string login, string pass)
        {
            using (var npgSqlConnection = new NpgsqlConnection(sql))
            {
                npgSqlConnection.Open();

                string query = "SELECT role_employee FROM employee WHERE login=@login AND employee_password=@password";
                using (var command = new NpgsqlCommand(query, npgSqlConnection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", pass);
                    string role = command.ExecuteScalar().ToString();
                    return role;

                }
            }
        }

        private string LoadIdShop(string login, string pass)
        {
            using (var npgSqlConnection = new NpgsqlConnection(sql))
            {
                npgSqlConnection.Open();

                string query = "SELECT id_shop FROM employee WHERE login=@login AND employee_password=@password";
                using (var command = new NpgsqlCommand(query, npgSqlConnection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", pass);
                    string id = command.ExecuteScalar().ToString();
                    return id;

                }
            }
        }
    }
}
