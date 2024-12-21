using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace NetworkShops
{
    internal class ConnectionDataBase
    {
        string connection = "Server=localhost;Port=5432;Database=course_project; User id = postgres; Password = totalWar1234;";

        public void initializationOfDataBase(string query)
        {
            using (NpgsqlConnection sqlconnection = new NpgsqlConnection(connection))
            {
                sqlconnection.Open();
                using (var cmd = new NpgsqlCommand(query, sqlconnection))
                {
                    cmd.ExecuteNonQuery();
                }
            }

        }

        public void dataView(string query, DataGridView dataGridView)
        {
            using (NpgsqlConnection sqlconnection = new NpgsqlConnection(connection))
            {
                sqlconnection.Open();

                using (var command = new NpgsqlCommand(query, sqlconnection))
                {
                    command.CommandType = CommandType.StoredProcedure; // Указываем, что это хранимая процедура

                    using (var adapter = new NpgsqlDataAdapter(command))
                    {                     
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable); // заполняет DataTable данными из данных
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Нет данных для отображения.");
                        }


                        dataGridView.DataSource = dataTable;
                    }
                }
            }
        }

        public void dataViewIdShop(string query, int idShop, DataGridView dataGridView)
        {
            using (NpgsqlConnection sqlconnection = new NpgsqlConnection(connection))
            {
                sqlconnection.Open();

                using (var command = new NpgsqlCommand(query, sqlconnection))
                {
                    command.CommandType = CommandType.StoredProcedure; // Указываем, что это хранимая процедура
                    command.Parameters.AddWithValue("idshop", idShop); // Добавляем параметр

                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable); // Заполняем DataTable данными из хранимой процедуры
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Нет данных для отображения.");
                        }


                        dataGridView.DataSource = dataTable; // Устанавливаем источник данных для DataGridView
                    }
                }
            }
        }
    }
}
