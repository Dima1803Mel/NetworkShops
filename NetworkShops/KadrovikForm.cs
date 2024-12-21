using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NetworkShops
{
    public partial class KadrovikForm : Form    
    {
        string sql = "Server=localhost;Port=5432;Database=course_project; User id = postgres; Password = totalWar1234;";

        ConnectionDataBase connDB = new ConnectionDataBase();

        public KadrovikForm()
        {
            InitializeComponent();

            Role.Items.Insert(0, "продавец");
            Role.Items.Insert(1, "кадровик");
            Role.Items.Insert(2, "директор магазина");
            Role.Items.Insert(3, "директор сети магазина");

            connDB.dataView("SELECT id_employee, login, employee_password, name_employee, familia, otchestvo, date_of_birth, number_phone, id_shop, salary, role_employee FROM employee;", dataGridView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            connDB.initializationOfDataBase($"CALL deleteemployee('{Convert.ToInt32(idEmployee.Text)}')");
            connDB.dataView("SELECT id_employee, login, employee_password, name_employee, familia, otchestvo, date_of_birth, number_phone, id_shop, salary, role_employee FROM employee;", dataGridView1);
            idEmployee.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void idShop_TextChanged(object sender, EventArgs e)
        {

        }

        private void Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateOfBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void Otchestvo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            string fDate = DateOfBirth.Text;
            DateTime date;
            try
            {
                date = DateTime.ParseExact(fDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                fDate = date.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Некорректный формат даты. Пожалуйста, введите дату в формате ГГГГ-ММ-ДД.");
            }

            connDB.initializationOfDataBase($"CALL incertemployee('{LoginField.Text}', '{PassField.Text}', '{Name.Text}', '{Familia.Text}', '{Otchestvo.Text}'," +
                $" '{Convert.ToDateTime(DateOfBirth.Text)}', '{Number.Text}', '{Convert.ToInt32(idShop.Text)}', '{Convert.ToInt32(Salary.Text)}', '{Role.SelectedIndex.ToString()}')");


            connDB.dataView("SELECT id_employee, login, employee_password, name_employee, familia, otchestvo, date_of_birth, number_phone, id_shop, salary, role_employee FROM employee;", dataGridView1);
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            Familia.Clear();
            Name.Clear();
            Otchestvo.Clear();
            DateOfBirth.Clear();
            Number.Clear();
            idShop.Clear();
            LoginField.Clear();
            PassField.Clear();
            Salary.Clear();
        }


        private void DateOfBirth_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void Number_TextChanged_1(object sender, EventArgs e)
        {
   
        }

        private void Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
