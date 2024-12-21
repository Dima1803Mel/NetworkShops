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
    public partial class Assistant : Form
    {
        string sql = "Server=localhost;Port=5432;Database=course_project; User id = postgres; Password = totalWar1234;";

        ConnectionDataBase connDB = new ConnectionDataBase();

        int id_Shop;

        public Assistant()
        {
            InitializeComponent();

            //connDB.dataView("SELECT id_product, id_shop, name_product, count_product, price FROM product;", dataGridView1);
            //connDB.dataView("SELECT id_product, id_buy, count_basket, discount, summa FROM product_buy;", dataGridView2);

            connDB.dataView("selectproductbuy", dataGridView2);
        }

        public Assistant(int idShop)
        {
            InitializeComponent();

            this.id_Shop = idShop;
            connDB.dataViewIdShop("selectproduct", id_Shop, dataGridView1);
            connDB.dataView("selectproductbuy", dataGridView2);
        }

        private void idProduct_TextChanged(object sender, EventArgs e)
        {
            LoadPriceProduct(Convert.ToInt32(idProduct.Text));
        }

        private void Price_TextChanged(object sender, EventArgs e)
        {
            UpdateSumma();
        }

        private void Summa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Discount_TextChanged(object sender, EventArgs e)
        {
            UpdateSumma();
        }

        private void CountProduct_TextChanged(object sender, EventArgs e)
        {
            UpdateSumma();
        }

        private void BuyProduct_Click(object sender, EventArgs e)
        {
            connDB.initializationOfDataBase($"CALL addlistbuy('{Convert.ToInt32(idProduct.Text)}', '{Convert.ToInt32(CountProduct.Text)}', '{Convert.ToInt32(Summa.Text)}', '{Convert.ToInt32(Discount.Text)}')");
            connDB.dataView("SELECT id_product, id_shop, name_product, count_product, price FROM product;", dataGridView1);
            connDB.dataView("SELECT id_product, id_buy, count_basket, discount, summa FROM product_buy;", dataGridView2);
        }

        private void buys_Click(object sender, EventArgs e)
        {
            connDB.initializationOfDataBase($"CALL buyProducts()");
            connDB.dataView("SELECT id_product, id_shop, name_product, count_product, price FROM product;", dataGridView1);
            connDB.dataView("SELECT id_product, id_buy, count_basket, discount, summa FROM product_buy;", dataGridView2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadPriceProduct(int productId)
        {

            using (var connection = new NpgsqlConnection(sql))
            {
                connection.Open();
                string query = "SELECT price FROM product WHERE id_product = @productId";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Читаем данные
                        {
                            // Получаем цену из reader
                            int productPrice = reader.GetInt32(0); // Получаем price

                            Price.Text = productPrice.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Продукт не найден.");
                        }
                    }
                }
            }
        }

        private void UpdateSumma()
        {
            // Попытка преобразовать значения из текстовых полей
            if (int.TryParse(Price.Text, out int price) &&
                int.TryParse(CountProduct.Text, out int count) &&
                int.TryParse(Discount.Text, out int discount))
            {
                // Вычисление суммы с учетом скидки
                int summa = (price * count) - discount;
                Summa.Text = summa.ToString();
            }
            else
            {
                // Если ввод некорректен, очищаем поле Summa
                Summa.Text = string.Empty;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
