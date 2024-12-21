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

namespace NetworkShops
{
    public partial class DirectorNetworkShops : Form
    {
        string sql = "Server=localhost;Port=5432;Database=course_project; User id = postgres; Password = totalWar1234;";

        ConnectionDataBase connDB = new ConnectionDataBase();

        public DirectorNetworkShops()
        {
            InitializeComponent();

            connDB.dataView("SELECT id_shop, place, income, expense FROM shop;", dataGridView1);
        }

        private void AddShop_Click(object sender, EventArgs e)
        {
            connDB.initializationOfDataBase($"CALL insertshop('{Convert.ToInt32(idShop.Text)}', '{PlaceShop.Text}')");
            connDB.dataView("SELECT id_shop, place, income, expense FROM shop;", dataGridView1);
            idShop.Clear();
            PlaceShop.Clear();
        }

        private void DeleteShop_Click(object sender, EventArgs e)
        {
            connDB.initializationOfDataBase($"CALL deleteShop('{Convert.ToInt32(idDeleteShop.Text)}')");
            connDB.dataView("SELECT id_shop, place, income, expense FROM shop;", dataGridView1);
            idDeleteShop.Clear();
        }
    }
}
