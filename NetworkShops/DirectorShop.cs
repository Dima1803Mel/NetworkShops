using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkShops
{
    public partial class DirectorShop : Form
    {
        string sql = "Server=localhost;Port=5432;Database=course_project; User id = postgres; Password = totalWar1234;";

        ConnectionDataBase connDB = new ConnectionDataBase();

        public DirectorShop()
        {
            InitializeComponent();

            connDB.dataView("SELECT id_product, id_shop, name_product, count_product, price FROM product;", dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            connDB.initializationOfDataBase($"CALL insertproduct('{Convert.ToInt32(idProduct.Text)}', '{nameProduct.Text}', '{Convert.ToInt32(countProduct.Text)}', '{Convert.ToInt32(price.Text)}')");

            connDB.dataView("SELECT id_product, id_shop, name_product, count_product, price FROM product;", dataGridView1);
            ClearTextBox();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            connDB.initializationOfDataBase($"CALL deleteproduct('{Convert.ToInt32(id_delete_product.Text)}')");

            connDB.dataView("SELECT id_product, id_shop, name_product, count_product, price FROM product;", dataGridView1);
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            idProduct.Clear();
            nameProduct.Clear();
            countProduct.Clear();
            price.Clear();
        }
    }
}
